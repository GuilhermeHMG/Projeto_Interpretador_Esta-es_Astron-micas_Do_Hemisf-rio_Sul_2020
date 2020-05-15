using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcEstacoesAno
{
    class InterpretadorEstacao
    {
        private Estacao[] estacoes = new Estacao[16];

        public InterpretadorEstacao()
        {
            estacoes[0] = new Estacao { diaInicio = 21, mesInicio = 9, diaFim = 20, mesFim = 12, nome = "Primavera", caracteristicas = "A primavera é a estação do ano que se segue ao inverno e precede o verão e é tipicamente associada ao reflorescimento da flora terrestre." };
            estacoes[1] = new Estacao { diaInicio = 1, mesInicio = 10, diaFim = 20, mesFim = 12, nome = "Primavera", caracteristicas = "A primavera é a estação do ano que se segue ao inverno e precede o verão e é tipicamente associada ao reflorescimento da flora terrestre." };
            estacoes[2] = new Estacao { diaInicio = 1, mesInicio = 11, diaFim = 20, mesFim = 12, nome = "Primavera", caracteristicas = "A primavera é a estação do ano que se segue ao inverno e precede o verão e é tipicamente associada ao reflorescimento da flora terrestre." };
            estacoes[3] = new Estacao { diaInicio = 1, mesInicio = 12, diaFim = 20, mesFim = 12, nome = "Primavera", caracteristicas = "A primavera é a estação do ano que se segue ao inverno e precede o verão e é tipicamente associada ao reflorescimento da flora terrestre." };
            estacoes[4] = new Estacao { diaInicio = 21, mesInicio = 12, diaFim = 20, mesFim = 3, nome = "Verão", caracteristicas = "O verão é uma das quatro estações do ano, caracterizada por ser a estação mais quente. Neste período, as temperaturas permanecem elevadas e os dias são mais longos do que os dias de outras estações. Geralmente, o verão é também o período do ano reservado às férias." };
            estacoes[5] = new Estacao { diaInicio = 1, mesInicio = 1, diaFim = 20, mesFim = 3, nome = "Verão", caracteristicas = "O verão é uma das quatro estações do ano, caracterizada por ser a estação mais quente. Neste período, as temperaturas permanecem elevadas e os dias são mais longos do que os dias de outras estações. Geralmente, o verão é também o período do ano reservado às férias." };
            estacoes[6] = new Estacao { diaInicio = 1, mesInicio = 2, diaFim = 20, mesFim = 3, nome = "Verão", caracteristicas = "O verão é uma das quatro estações do ano, caracterizada por ser a estação mais quente. Neste período, as temperaturas permanecem elevadas e os dias são mais longos do que os dias de outras estações. Geralmente, o verão é também o período do ano reservado às férias." };
            estacoes[7] = new Estacao { diaInicio = 1, mesInicio = 3, diaFim = 20, mesFim = 3, nome = "Verão", caracteristicas = "O verão é uma das quatro estações do ano, caracterizada por ser a estação mais quente. Neste período, as temperaturas permanecem elevadas e os dias são mais longos do que os dias de outras estações. Geralmente, o verão é também o período do ano reservado às férias." };
            estacoes[8] = new Estacao { diaInicio = 21, mesInicio = 3, diaFim = 20, mesFim = 6, nome = "Outono", caracteristicas = "O outono é a estação do ano que sucede o verão e antecede o inverno. Nas regiões de clima temperado ou subtropical é caraterizado por queda gradativa na temperatura e pelo amarelar e início da queda das folhas das árvores, que indica a passagem das estações." };
            estacoes[9] = new Estacao { diaInicio = 1, mesInicio = 4, diaFim = 20, mesFim = 6, nome = "Outono", caracteristicas = "O outono é a estação do ano que sucede o verão e antecede o inverno. Nas regiões de clima temperado ou subtropical é caraterizado por queda gradativa na temperatura e pelo amarelar e início da queda das folhas das árvores, que indica a passagem das estações." };
            estacoes[10] = new Estacao { diaInicio = 1, mesInicio = 5, diaFim = 20, mesFim = 6, nome = "Outono", caracteristicas = "O outono é a estação do ano que sucede o verão e antecede o inverno. Nas regiões de clima temperado ou subtropical é caraterizado por queda gradativa na temperatura e pelo amarelar e início da queda das folhas das árvores, que indica a passagem das estações." };
            estacoes[11] = new Estacao { diaInicio = 1, mesInicio = 6, diaFim = 20, mesFim = 6, nome = "Outono", caracteristicas = "O outono é a estação do ano que sucede o verão e antecede o inverno. Nas regiões de clima temperado ou subtropical é caraterizado por queda gradativa na temperatura e pelo amarelar e início da queda das folhas das árvores, que indica a passagem das estações." };
            estacoes[12] = new Estacao { diaInicio = 21, mesInicio = 6, diaFim = 20, mesFim = 9, nome = "Inverno", caracteristicas = "O inverno é a estação mais fria das quatro estações do ano e é comum que durante esta época, em países mais perto dos polos, as temperaturas fiquem abaixo de 0ºC e que ocorram fenômenos como a queda de neve e a formação de geada." };
            estacoes[13] = new Estacao { diaInicio = 1, mesInicio = 7, diaFim = 20, mesFim = 9, nome = "Inverno", caracteristicas = "O inverno é a estação mais fria das quatro estações do ano e é comum que durante esta época, em países mais perto dos polos, as temperaturas fiquem abaixo de 0ºC e que ocorram fenômenos como a queda de neve e a formação de geada." };
            estacoes[14] = new Estacao { diaInicio = 1, mesInicio = 8, diaFim = 20, mesFim = 9, nome = "Inverno", caracteristicas = "O inverno é a estação mais fria das quatro estações do ano e é comum que durante esta época, em países mais perto dos polos, as temperaturas fiquem abaixo de 0ºC e que ocorram fenômenos como a queda de neve e a formação de geada." };
            estacoes[15] = new Estacao { diaInicio = 1, mesInicio = 9, diaFim = 20, mesFim = 9, nome = "Inverno", caracteristicas = "O inverno é a estação mais fria das quatro estações do ano e é comum que durante esta época, em países mais perto dos polos, as temperaturas fiquem abaixo de 0ºC e que ocorram fenômenos como a queda de neve e a formação de geada." };
        }

        public Estacao Interpretar(int dia, int mes)
        {
            Estacao estacao = null;
            for (int i = 0; i < estacoes.Length; i++)
            {
                if ((dia >= estacoes[i].diaInicio && mes == estacoes[i].mesInicio) || (dia <= estacoes[i].diaFim && mes == estacoes[i].mesFim))
                {
                    estacao = estacoes[i];
                }
            }
            return estacao;
        }
    }
}
