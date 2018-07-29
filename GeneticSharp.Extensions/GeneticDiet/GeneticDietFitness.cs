using System;
using System.Diagnostics.CodeAnalysis;
using EF;
using GeneticSharp.Domain;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Fitnesses;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Terminations;
using GeneticSharp.Infrastructure.Framework.Threading;

namespace GeneticSharp.Extensions.GeneticDiet
{
    /// <summary>
    /// A fitness function to auto config another genetic algorithm.
    /// </summary>
    public sealed class GeneticDietFitness : IFitness
    {
        #region Constructor               
        
        public GeneticDietFitness(int Grasa, int Proteina, int Calorias, int Carbohidrato)
        {
            this.Grasa = Grasa;
            this.Proteina = Proteina;
            this.Calorias = Calorias;
            this.Carbohidrato = Carbohidrato;

        }

        #endregion

        #region Valores de entrada de agente de dieta

        public int Grasa { get; set; }

        public int Proteina { get; set; }

        public int Calorias { get; set; }

        public int Carbohidrato { get; set; }

        #endregion


        #region Methods        
        /// <summary>
        /// Evaluates the specified chromosome.
        /// </summary>
        /// <param name="chromosome">The chromosome.</param>
        /// <returns>The chromosome fitness.</returns>
        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        public double Evaluate(IChromosome chromosome)
        {
            chromosome = chromosome as GeneticDietChromosome;

            double aptitud = 0;

            double carbohidratoAcumulado = 0.0;
            double grasaAcumulada = 0.0;
            double proteinasAcumuladas = 0.0;
            double caloriasAcumuladas = 0.0;

            if (Calorias != 0 && Proteina != 0 && Carbohidrato != 0 && Grasa != 0)
            {

                foreach (var item in chromosome.GetGenes())
                {
                    EF.GenDB gendb = (EF.GenDB)item.Value;

                    foreach (var nutriente in gendb.listNutrient)
                    {
                        //Grasas
                        if (nutriente.NutrientId == 204)
                        {
                            grasaAcumulada = Convert.ToInt32(nutriente.ValueNutrient);
                        }

                        //Carbohidratos
                        if (nutriente.NutrientId == 205)
                        {
                            grasaAcumulada = Convert.ToInt32(nutriente.ValueNutrient);
                        }

                        //Proteinas
                        if (nutriente.NutrientId == 203)
                        {
                            grasaAcumulada = Convert.ToInt32(nutriente.ValueNutrient);
                        }

                        //Calorias
                        if (nutriente.NutrientId == 208)
                        {
                            grasaAcumulada = Convert.ToInt32(nutriente.ValueNutrient);
                        }
                    }
                }

                // Aca se tiene en cuenta la entrada del Agente anterior
                if (carbohidratoAcumulado >= 0 && carbohidratoAcumulado > Carbohidrato)
                    aptitud += -10;

                if (proteinasAcumuladas >= 0 && proteinasAcumuladas >= Proteina)
                    aptitud += 20;

                if (caloriasAcumuladas >= 0 && caloriasAcumuladas > Calorias)
                    aptitud += -50;

                if (grasaAcumulada >= 0 && grasaAcumulada > Grasa)
                    aptitud += -30;

                return aptitud;
            }
            
            
            foreach (var item in chromosome.GetGenes())
            {
                EF.GenDB gendb = (EF.GenDB)item.Value;

                foreach (var nutriente in gendb.listNutrient)
                {                  
                    //Grasas
                    if(nutriente.NutrientId == 204)
                    {
                        if (nutriente.ValueNutrient > 34)
                            //Agrasas = 20;
                            grasaAcumulada += -20;
                        else if (nutriente.ValueNutrient >= 20 && nutriente.ValueNutrient <= 34)
                            //Agrasas = 50;
                            grasaAcumulada += 20;
                        else if (nutriente.ValueNutrient >= 6 && nutriente.ValueNutrient < 20)
                            grasaAcumulada += 50;
                        else if (nutriente.ValueNutrient < 6)
                            grasaAcumulada += 60;                       
                    }

                    //Carbohidratos
                    if (nutriente.NutrientId == 205)
                    {
                        if (0 < nutriente.ValueNutrient && nutriente.ValueNutrient <= 20)
                        {
                            carbohidratoAcumulado += 50;
                        }

                        if (20 < nutriente.ValueNutrient && nutriente.ValueNutrient <= 50)
                        {
                            carbohidratoAcumulado += 20;
                        }

                        if (50 > nutriente.ValueNutrient)
                        {
                            carbohidratoAcumulado += -20;
                        }                        
                    }

                    //Proteinas
                    if (nutriente.NutrientId == 203)
                    {
                        if (nutriente.ValueNutrient > 70)
                            proteinasAcumuladas += 70;
                        else if (nutriente.ValueNutrient >= 20 && nutriente.ValueNutrient <= 80)
                            proteinasAcumuladas += 50;
                        else if (nutriente.ValueNutrient < 20)
                            proteinasAcumuladas += 20;

                    }

                    //Calorias
                    if (nutriente.NutrientId == 208)
                    {
                        if (nutriente.ValueNutrient >= 800)
                            caloriasAcumuladas += 20;
                        else if (nutriente.ValueNutrient >= 200 && nutriente.ValueNutrient < 800)
                            caloriasAcumuladas += 50;
                        else if (nutriente.ValueNutrient < 200)
                            caloriasAcumuladas += 80;                        
                    }
                    
                }
            }                

            aptitud += grasaAcumulada + proteinasAcumuladas + caloriasAcumuladas + carbohidratoAcumulado;

            return (aptitud) / 4;
        }
        #endregion
    }
}
