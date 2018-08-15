using System;
using Turistiando.Modelos;

namespace Turistiando
{
    class AlgoritmoGenetico
    {
        private Lugar lugares;
        private API api;

        private string[] individuos;
        private double[] pesos;
        private double[] ganancias;

        //Variables originales del algoritmo genetico
        private string mejorHijo;
        private double mejorGanancia;
        private double mejorPeso;

        private string[] hijosAux;

        private double[] fnorm;
        private double[] acumulado;
        private double[] aleatorios;

        private double[] padresPosicion;
        private string[] padres;
        private string[] hijos;

        private double auxF;
        private double sumX;
        //

        private int numpoblacion = 100;
        private int generaciones = 500;
        private double probCruce = 0.65;
        private double probMutacion = 0.01;
        
        private int capacity;
        private double[] profits;
        private double[] weights;

        public AlgoritmoGenetico(int _capacity )
        {
            api = new API();

            capacity = _capacity;

            individuos = new string[numpoblacion];
        }

        public string main(Lugar lugares_lista)
        {
            lugares = lugares_lista;

            capturaDeDatos();

            inicializacion();

            evaluacion();
            
            for(int i=0; i<generaciones; i++)
            {
                iniciarValores();

                seleccion();

                cruce();

                mutacion();
            }
            

            return mejorHijo;
            
        }

        #region Datos
        private void iniciarValores()
        {
            //Se reinician los valores
            pesos = new double[numpoblacion];
            ganancias = new double[numpoblacion];

            fnorm = new double[numpoblacion];
            acumulado = new double[numpoblacion];
            aleatorios = new double[numpoblacion];
            padresPosicion = new double[numpoblacion];
            padres = new string[numpoblacion];
            hijos = new string[numpoblacion];

            auxF = 0.0;
            sumX = 0.0;
        }

        private void capturaDeDatos()
        {
            profits = new double[lugares.Results.Length];
            weights = new double[lugares.Results.Length];

            for(int i=0; i<lugares.Results.Length; i++)
            {
                //Se guarda el rating del lugar
                profits[i] = lugares.Results[i].Rating;
                
                //Se obtiene la latitud y longitud ara mandarsela como parametro al metodo de obtener ruta
                string latitud = lugares.Results[i].Geometry.Location.Lat.ToString();
                string longitud = lugares.Results[i].Geometry.Location.Lng.ToString();
 
                //Se almacena el tiempo en segundos
                weights[i] = api.obtenerRuta(latitud, longitud).Routes[0].Legs[0].Duration.Value;
            }

        }
        #endregion

        #region Algoritmo Genetico
        private void inicializacion() {

            Random rnd = new Random();
            string individuo_aux;

            for (int i=0; i < numpoblacion; i++) {

                individuo_aux = "";

                for(int j=0; j<lugares.Results.Length; j++) {
                    
                    int aleatorio = rnd.Next(0, 2);
                    individuo_aux += aleatorio.ToString();

                }

                individuos[i] = individuo_aux;

            }

        }

        private double funcionObjetivo(int _individuo)
        {
            double ganancia = 0;

            for (int i = 0; i < lugares.Results.Length; i++)
                ganancia += (Convert.ToInt32(individuos[_individuo].Substring(i, 1)) * profits[i]);

            return ganancia;

        }

        private double obtenerPeso(int _individuo)
        {
            double peso = 0;

            for (int i = 0; i < lugares.Results.Length; i++)
                peso += (Convert.ToInt32(individuos[_individuo].Substring(i, 1)) * weights[i]);

            return peso;
        }

        private void seleccion()
        {
            for(int i=0; i<numpoblacion; i++){
                pesos[i] = obtenerPeso(i);
                ganancias[i] = funcionObjetivo(i);

                sumX = sumX + ganancias[i];
            }

            for (int i=0; i<numpoblacion; i++)
            {
                fnorm[i] = (ganancias[i]/sumX);
                auxF = auxF + fnorm[i];
            }

            
            Random rnd = new Random();

            for (int i = 0; i < numpoblacion; i++)
            {
                if (i == 0)
                    acumulado[i] = fnorm[i];
                else
                    acumulado[i] = (fnorm[i] + acumulado[i - 1]);

                aleatorios[i] = rnd.NextDouble();

            }

            for (int i = 0; i < numpoblacion; i++)
            {
                for (int j = 0; j < numpoblacion; j++)
                {
                    if (acumulado[j] > aleatorios[i])
                    {
                        padresPosicion[i] = j;
                        padres[i] = individuos[j];
                        break;
                    }
                }

            }
        }

        private void cruce()
        {
            Random rnd = new Random();
            hijos = padres;

            for(int i=0; i<numpoblacion; i+=2){

                string cortePadre1 = "";
                string cortePadre2 = "";
                string padre1corte1 = "";
                string padre1corte2 = "";
                string padre2corte1 = "";
                string padre2corte2 = "";

                double auxAleatorio = rnd.NextDouble();
                
                if(auxAleatorio <= probCruce)
                {
                    int puntoCorte1 = rnd.Next(0, lugares.Results.Length);
                    int puntoCorte2 = rnd.Next(0, lugares.Results.Length);

                    while(puntoCorte2 == puntoCorte1)
                        puntoCorte2 = rnd.Next(0, lugares.Results.Length);

                    if (puntoCorte1 < puntoCorte2)
                    {
                        cortePadre1 = padres[i].Substring(puntoCorte1, puntoCorte2+1-puntoCorte1);
                        cortePadre2 = padres[i+1].Substring(puntoCorte1, puntoCorte2+1-puntoCorte1);
                        
                        hijos[i] = padres[i].Substring(0, puntoCorte1) + cortePadre2 + padres[i].Substring(puntoCorte2 + 1);
                        hijos[i+1] = padres[i+1].Substring(0, puntoCorte1) + cortePadre1 + padres[i+1].Substring(puntoCorte2 + 1);
                        
                    }
                    else if (puntoCorte1 > puntoCorte2)
                    {
                        padre1corte1 = padres[i].Substring(0, puntoCorte2 + 1);
                        padre1corte2 = padres[i].Substring(puntoCorte1);
                        padre2corte1 = padres[i+1].Substring(0, puntoCorte2 + 1);
                        padre2corte2 = padres[i+1].Substring(puntoCorte1);

                        hijos[i] = padre2corte1 + padres[i].Substring(puntoCorte2+1, puntoCorte1-puntoCorte2-1) + padre2corte2;
                        hijos[i + 1] = padre1corte1 + padres[i + 1].Substring(puntoCorte2+1, puntoCorte1-puntoCorte2-1) + padre1corte2;

                    }

                }
            }
        }

        private void mutacion()
        {
            Random rnd = new Random();

            for (int i=0; i<numpoblacion; i++)
            {
                for (int j=0; j<lugares.Results.Length; j++)
                {
                    double auxAleatorio = rnd.NextDouble();

                    if (auxAleatorio < probMutacion)
                    {
                        if (hijos[i][j] == '0')
                            hijos[i] = hijos[i].Substring(0, j) + "1" + hijos[i].Substring(j+1);
                        else if (hijos[i][j] == '1')
                            hijos[i] = hijos[i].Substring(0, j) + "0" + hijos[i].Substring(j + 1);

                    }

                }

            }

            individuos = hijos;

            evaluacion();

            //Tal vez sea clone
            hijosAux = hijos;

            obtenerMejorHijo(hijosAux);

        }

        private void obtenerMejorHijo(string[] listaux)
        {
            pesos = new double[numpoblacion];
            ganancias = new double[numpoblacion];

            for (int i=0; i<listaux.Length; i++)
            {
                double ganancia = 0;
                double peso = 0;

                for(int j=0; j<lugares.Results.Length; j++)
                {
                    ganancia += (Convert.ToInt32(listaux[i].Substring(j, 1)) * profits[j]);
                    peso += (Convert.ToInt32(listaux[i].Substring(j, 1)) * weights[j]);
                }


                pesos[i] = peso;
                ganancias[i] = ganancia;

            }


            for (int i=0; i<listaux.Length; i++)
            {
                if( ganancias[i] > mejorGanancia)
                {
                    mejorHijo = listaux[i];
                    mejorGanancia = ganancias[i];
                    mejorPeso = pesos[i];
                }
            }

        }
        
        #endregion

        #region Reparacion Voraz

        private void evaluacion()
        {
            Random rnd = new Random();
            Boolean knapsack_overfield = false;

            for(int i = 0; i < numpoblacion; i++){

                if (obtenerPeso(i) > capacity)
                    knapsack_overfield = true;
                
                while (knapsack_overfield)
                {
                    int j = rnd.Next(0, lugares.Results.Length);
                    individuos[i] = individuos[i].Substring(0,j) + "0" + individuos[i].Substring(j+1);
                    if (obtenerPeso(i) < capacity)
                        knapsack_overfield = false;
                }
            }
        }

        #endregion

    }
}
