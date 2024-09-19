namespace Showdomiliao
{
    public class Gerenciador
    {
        List<Questao> ListaQuestoes = new List<Questao>();
        List<int> ListaQuestoesRespondidas = new List<int>();
        Questao QuestaoAtual;
        public Gerenciador(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            CriarQuestoes(labelpergunta, button1, button2, button3, button4, button5);
        }
        void CriarQuestoes(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            var Q1 = new Questao();
            Q1.Pergunta = "Qual é o planeta mais próximo do Sol?";
            Q1.Resposta01 = "Vênus";
            Q1.Resposta02 = "Marte";
            Q1.Resposta03 = "Júpiter";
            Q1.Resposta04 = "Mercúrio";
            Q1.Resposta05 = "Saturno";
            Q1.RespostaCorreta = 4;
            Q1.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q1);

            var Q2 = new Questao();
            Q2.Pergunta = "Quem escreveu 'Dom Quixote'?";
            Q2.Resposta01 = "William Shakespeare";
            Q2.Resposta02 = "Miguel de Cervantes";
            Q2.Resposta03 = "Gabriel García Márquez";
            Q2.Resposta04 = "Jorge Amado";
            Q2.Resposta05 = "Machado de Assis";
            Q2.RespostaCorreta = "Miguel de Cervantes";
            Q2.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q2);

            var Q3 = new Questao();
            Q3.Pergunta = "Qual é a capital da Austrália?";
            Q3.Resposta01 = "Sydney";
            Q3.Resposta02 = "Melbourne";
            Q3.Resposta03 = "Canberra";
            Q3.Resposta04 = "Perth";
            Q3.Resposta05 = "Brisbane";
            Q3.RespostaCorreta = "Canberra";
            Q3.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q3);

            var Q4 = new Questao();
            Q4.Pergunta = "Quem foi o primeiro presidente do Brasil?";
            Q4.Resposta01 = "Getúlio Vargas";
            Q4.Resposta02 = "Juscelino Kubitschek";
            Q4.Resposta03 = "Marechal Deodoro da Fonseca";
            Q4.Resposta04 = "Dom Pedro II";
            Q4.Resposta05 = "Epitácio Pessoa";
            Q4.RespostaCorreta = "Marechal Deodoro da Fonseca";
            Q4.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q4);

            var Q5 = new Questao();
            Q5.Pergunta = "Qual é a fórmula química da água?";
            Q5.Resposta01 = "H2O2";
            Q5.Resposta02 = "CO2";
            Q5.Resposta03 = "H2O";
            Q5.Resposta04 = "O2";
            Q5.Resposta05 = "CH4";
            Q5.RespostaCorreta = "H2O";
            Q5.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q5);

            var Q6 = new Questao();
            Q6.Pergunta = "Quem pintou a Mona Lisa?";
            Q6.Resposta01 = "Pablo Picasso";
            Q6.Resposta02 = "Leonardo da Vinci";
            Q6.Resposta03 = "Vincent van Gogh";
            Q6.Resposta04 = "Michelangelo";
            Q6.Resposta05 = "Salvador Dalí";
            Q6.RespostaCorreta = "Leonardo da Vinci";
            Q6.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q6);

            var Q7 = new Questao();
            Q7.Pergunta = "Qual o maior país em extensão territorial?";
            Q7.Resposta01 = "China";
            Q7.Resposta02 = "Canadá";
            Q7.Resposta03 = "Estados Unidos";
            Q7.Resposta04 = "Brasil";
            Q7.Resposta05 = "Rússia";
            Q7.RespostaCorreta = "Rússia";
            Q7.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q7);

            var Q8 = new Questao();
            Q8.Pergunta = "Qual a principal moeda do Japão?";
            Q8.Resposta01 = "Dólar";
            Q8.Resposta02 = "Euro";
            Q8.Resposta03 = "Yuan";
            Q8.Resposta04 = "Iene";
            Q8.Resposta05 = "Won";
            Q8.RespostaCorreta = "Iene";
            Q8.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q8);

            var Q9 = new Questao();
            Q9.Pergunta = "Quem é o autor da teoria da evolução?";
            Q9.Resposta01 = "Isaac Newton";
            Q9.Resposta02 = "Albert Einstein";
            Q9.Resposta03 = "Charles Darwin";
            Q9.Resposta04 = "Gregor Mendel";
            Q9.Resposta05 = "Galileo Galilei";
            Q9.RespostaCorreta = "Charles Darwin";
            Q9.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q9);

            var Q10 = new Questao();
            Q10.Pergunta = "Qual a camada da atmosfera responsável pela proteção contra raios UV?";
            Q10.Resposta01 = "Estratosfera";
            Q10.Resposta02 = "Troposfera";
            Q10.Resposta03 = "Exosfera";
            Q10.Resposta04 = "Mesosfera";
            Q10.Resposta05 = "Ionosfera";
            Q10.RespostaCorreta = "Estratosfera";
            Q10.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q10);

            var Q11 = new Questao();
            Q11.Pergunta = "Qual é o maior oceano do mundo?";
            Q11.Resposta01 = "Oceano Atlântico";
            Q11.Resposta02 = "Oceano Índico";
            Q11.Resposta03 = "Oceano Ártico";
            Q11.Resposta04 = "Oceano Pacífico";
            Q11.Resposta05 = "Oceano Antártico";
            Q11.RespostaCorreta = "Oceano Pacífico";
            Q11.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q11);

            var Q12 = new Questao();
            Q12.Pergunta = "Qual país é conhecido por ter o formato de uma bota?";
            Q12.Resposta01 = "Espanha";
            Q12.Resposta02 = "Grécia";
            Q12.Resposta03 = "França";
            Q12.Resposta04 = "Itália";
            Q12.Resposta05 = "Portugal";
            Q12.RespostaCorreta = "Itália";
            Q12.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q12);

            var Q13 = new Questao();
            Q13.Pergunta = "Qual desses animais é um mamífero?";
            Q13.Resposta01 = "Cobra";
            Q13.Resposta02 = "Golfinho";
            Q13.Resposta03 = "Galinha";
            Q13.Resposta04 = "Sapo";
            Q13.Resposta05 = "Crocodilo";
            Q13.RespostaCorreta = "Golfinho";
            Q13.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q13);

            var Q14 = new Questao();
            Q14.Pergunta = "Quem descobriu o Brasil?";
            Q14.Resposta01 = "Cristóvão Colombo";
            Q14.Resposta02 = "Pedro Álvares Cabral";
            Q14.Resposta03 = "Vasco da Gama";
            Q14.Resposta04 = "Fernando de Magalhães";
            Q14.Resposta05 = "Amerigo Vespucci";
            Q14.RespostaCorreta = "Pedro Álvares Cabral";
            Q14.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q14);

            var Q15 = new Questao();
            Q15.Pergunta = "Qual é o menor estado do Brasil em extensão territorial?";
            Q15.Resposta01 = "Alagoas";
            Q15.Resposta02 = "Rio de Janeiro";
            Q15.Resposta03 = "Espírito Santo";
            Q15.Resposta04 = "Sergipe";
            Q15.Resposta05 = "Acre";
            Q15.RespostaCorreta = "Sergipe";
            Q15.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q15);

            var Q16 = new Questao();
            Q16.Pergunta = "Em que ano ocorreu a Proclamação da República no Brasil?";
            Q16.Resposta01 = "1808";
            Q16.Resposta02 = "1822";
            Q16.Resposta03 = "1889";
            Q16.Resposta04 = "1900";
            Q16.Resposta05 = "1922";
            Q16.RespostaCorreta = "1889";
            Q16.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q16);

            var Q17 = new Questao();
            Q17.Pergunta = "Qual desses elementos químicos é um metal?";
            Q17.Resposta01 = "Hélio";
            Q17.Resposta02 = "Oxigênio";
            Q17.Resposta03 = "Enxofre";
            Q17.Resposta04 = "Ferro";
            Q17.Resposta05 = "Cloro";
            Q17.RespostaCorreta = "Ferro";
            Q17.Q.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q17);

            var Q18 = new Questao();
            Q18.Pergunta = "Qual é o maior deserto do mundo?";
            Q18.Resposta01 = "Saara";
            Q18.Resposta02 = "Kalahari";
            Q18.Resposta03 = "Deserto da Arábia";
            Q18.Resposta04 = "Deserto de Gobi";
            Q18.Resposta05 = "Antártida";
            Q18.RespostaCorreta = "Antártida";
            Q18.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q18);

            var Q19 = new Questao();
            Q19.Pergunta = "Quem é conhecido como o 'pai da aviação' no Brasil?";
            Q19.Resposta01 = "Alberto Santos Dumont";
            Q19.Resposta02 = "Irmãos Wright";
            Q19.Resposta03 = "Bartolomeu de Gusmão";
            Q19.Resposta04 = "Charles Lindbergh";
            Q19.Resposta05 = "Leonardo da Vinci";
            Q19.RespostaCorreta = "Alberto Santos Dumont";
            Q19.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q19);

            var Q20 = new Questao();
            Q20.Pergunta = "Qual é o nome da maior floresta tropical do mundo?";
            Q20.Resposta01 = "Floresta Amazônica";
            Q20.Resposta02 = "Floresta Negra";
            Q20.Resposta03 = "Taiga";
            Q20.Resposta04 = "Floresta do Congo";
            Q20.Resposta05 = "Floresta de Borneo";
            Q20.RespostaCorreta = "Floresta Amazônica";
            Q20.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q20);

            var Q21 = new Questao();
            Q21.Pergunta = "Qual a capital da França?";
            Q21.Resposta01 = "Berlim";
            Q21.Resposta02 = "Paris";
            Q21.Resposta03 = "Roma";
            Q21.Resposta04 = "Madri";
            Q21.Resposta05 = "Lisboa";
            Q21.RespostaCorreta = "Paris";
            Q21.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q21);

            var Q22 = new Questao();
            Q22.Pergunta = "Quem desenvolveu a teoria da relatividade?";
            Q22.Resposta01 = "Isaac Newton";
            Q22.Resposta02 = "Nikola Tesla";
            Q22.Resposta03 = "Albert Einstein";
            Q22.Resposta04 = "Stephen Hawking";
            Q22.Resposta05 = "Marie Curie";
            Q22.RespostaCorreta = "Albert Einstein";
            Q22.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q22);

            var Q23 = new Questao();
            Q23.Pergunta = "Qual a montanha mais alta do mundo?";
            Q23.Resposta01 = "K2";
            Q23.Resposta02 = "Everest";
            Q23.Resposta03 = "Kangchenjunga";
            Q23.Resposta04 = "Makalu";
            Q23.Resposta05 = "Lhotse";
            Q23.RespostaCorreta = "Everest";
            Q23.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q23);

            var Q24 = new Questao();
            Q24.Pergunta = "Qual é o país mais populoso do mundo?";
            Q24.Resposta01 = "Índia";
            Q24.Resposta02 = "Estados Unidos";
            Q24.Resposta03 = "Brasil";
            Q24.Resposta04 = "China";
            Q24.Resposta05 = "Indonésia";
            Q24.RespostaCorreta = "China";
            Q24.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q24);

            var Q25 = new Questao();
            Q25.Pergunta = "Qual é o maior animal terrestre?";
            Q25.Resposta01 = "Elefante Africano";
            Q25.Resposta02 = "Girafa";
            Q25.Resposta03 = "Rinoceronte";
            Q25.Resposta04 = "Hipopótamo";
            Q25.Resposta05 = "Leão";
            Q25.RespostaCorreta = "Elefante Africano";
            Q25.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q25);

            var Q26 = new Questao();
            Q26.Pergunta = "Qual a capital da Argentina?";
            Q26.Resposta01 = "Santiago";
            Q26.Resposta02 = "Lima";
            Q26.Resposta03 = "Buenos Aires";
            Q26.Resposta04 = "Caracas";
            Q26.Resposta05 = "Bogotá";
            Q26.RespostaCorreta = "Buenos Aires";
            Q26.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q26);

            var Q27 = new Questao();
            Q27.Pergunta = "Quem pintou o teto da Capela Sistina?";
            Q27.Resposta01 = "Leonardo da Vinci";
            Q27.Resposta02 = "Vincent van Gogh";
            Q27.Resposta03 = "Michelangelo";
            Q27.Resposta04 = "Claude Monet";
            Q27.Resposta05 = "Pablo Picasso";
            Q27.RespostaCorreta = "Michelangelo";
            Q27.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q27);

            var Q28 = new Questao();
            Q28.Pergunta = "Qual é o metal cujo símbolo químico é Fe?";
            Q28.Resposta01 = "Ouro";
            Q28.Resposta02 = "Prata";
            Q28.Resposta03 = "Ferro";
            Q28.Resposta04 = "Cobre";
            Q28.Resposta05 = "Mercúrio";
            Q28.RespostaCorreta = "Ferro";
            Q28.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q28);

            var Q29 = new Questao();
            Q29.Pergunta = "Quem foi o primeiro homem a pisar na Lua?";
            Q29.Resposta01 = "Yuri Gagarin";
            Q29.Resposta02 = "Buzz Aldrin";
            Q29.Resposta03 = "Neil Armstrong";
            Q29.Resposta04 = "Michael Collins";
            Q29.Resposta05 = "Alan Shepard";
            Q29.RespostaCorreta = "Neil Armstrong";
            Q29.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q29);

            var Q30 = new Questao();
            Q30.Pergunta = "Qual é o maior país da América do Sul?";
            Q30.Resposta01 = "Argentina";
            Q30.Resposta02 = "Peru";
            Q30.Resposta03 = "Colômbia";
            Q30.Resposta04 = "Brasil";
            Q30.Resposta05 = "Chile";
            Q30.RespostaCorreta = "Brasil";
            Q30.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q30);

            var Q31 = new Questao();
            Q31.Pergunta = "Qual é a língua mais falada no mundo?";
            Q31.Resposta01 = "Espanhol";
            Q31.Resposta02 = "Chinês";
            Q31.Resposta03 = "Inglês";
            Q31.Resposta04 = "Francês";
            Q31.Resposta05 = "Árabe";
            Q31.RespostaCorreta = "Chinês";
            Q31.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q31);

            var Q32 = new Questao();
            Q32.Pergunta = "Quantos continentes existem na Terra?";
            Q32.Resposta01 = "4";
            Q32.Resposta02 = "5";
            Q32.Resposta03 = "6";
            Q32.Resposta04 = "7";
            Q32.Resposta05 = "8";
            Q32.RespostaCorreta = "7";
            Q32.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q32);

            var Q33 = new Questao();
            Q33.Pergunta = "Qual é a maior ilha do mundo?";
            Q33.Resposta01 = "Madagascar";
            Q33.Resposta02 = "Groenlândia";
            Q33.Resposta03 = "Austrália";
            Q33.Resposta04 = "Islândia";
            Q33.Resposta05 = "Nova Zelândia";
            Q33.RespostaCorreta = "Groenlândia";
            Q33.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q33);

            var Q34 = new Questao();
            Q34.Pergunta = "Qual é o país mais extenso da Europa?";
            Q34.Resposta01 = "França";
            Q34.Resposta02 = "Alemanha";
            Q34.Resposta03 = "Espanha";
            Q34.Resposta04 = "Rússia";
            Q34.Resposta05 = "Itália";
            Q34.RespostaCorreta = "Rússia";
            Q34.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q34);

            var Q35 = new Questao();
            Q35.Pergunta = "Qual é o estado brasileiro conhecido como 'Terra da Garoa'?";
            Q35.Resposta01 = "Rio de Janeiro";
            Q35.Resposta02 = "Minas Gerais";
            Q35.Resposta03 = "Espírito Santo";
            Q35.Resposta04 = "São Paulo";
            Q35.Resposta05 = "Paraná";
            Q35.RespostaCorreta = "São Paulo";
            Q35.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q35);

            var Q36 = new Questao();
            Q36.Pergunta = "Quem foi o primeiro imperador do Brasil?";
            Q36.Resposta01 = "Dom Pedro I";
            Q36.Resposta02 = "Dom Pedro II";
            Q36.Resposta03 = "Getúlio Vargas";
            Q36.Resposta04 = "Juscelino Kubitschek";
            Q36.Resposta05 = "Floriano Peixoto";
            Q36.RespostaCorreta = "Dom Pedro I";
            Q36.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q36);

            var Q37 = new Questao();
            Q37.Pergunta = "Quantos estados o Brasil tem?";
            Q37.Resposta01 = "24";
            Q37.Resposta02 = "25";
            Q37.Resposta03 = "26";
            Q37.Resposta04 = "27";
            Q37.Resposta05 = "28";
            Q37.RespostaCorreta = "26";
            Q37.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q37);

            var Q38 = new Questao();
            Q38.Pergunta = "Qual é a menor unidade estrutural dos organismos vivos?";
            Q38.Resposta01 = "Molécula";
            Q38.Resposta02 = "Célula";
            Q38.Resposta03 = "Átomo";
            Q38.Resposta04 = "Tecido";
            Q38.Resposta05 = "Organelo";
            Q38.RespostaCorreta = "Célula";
            Q38.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q38);

            var Q39 = new Questao();
            Q39.Pergunta = "Em qual país se localiza o rio Nilo?";
            Q39.Resposta01 = "Índia";
            Q39.Resposta02 = "Egito";
            Q39.Resposta03 = "China";
            Q39.Resposta04 = "México";
            Q39.Resposta05 = "Brasil";
            Q39.RespostaCorreta = "Egito";
            Q39.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q39);

            var Q40 = new Questao();
            Q40.Pergunta = "Qual o número do átomo de carbono na tabela periódica?";
            Q40.Resposta01 = "4";
            Q40.Resposta02 = "6";
            Q40.Resposta03 = "8";
            Q40.Resposta04 = "10";
            Q40.Resposta05 = "12";
            Q40.RespostaCorreta = "6";
            Q40.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q40);

            var Q41 = new Questao();
            Q41.Pergunta = "Em que ano o homem chegou à Lua pela primeira vez?";
            Q41.Resposta01 = "1959";
            Q41.Resposta02 = "1965";
            Q41.Resposta03 = "1969";
            Q41.Resposta04 = "1972";
            Q41.Resposta05 = "1975";
            Q41.RespostaCorreta = "1969";
            Q41.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q41);

            var Q42 = new Questao();
            Q42.Pergunta = "Qual é o nome do processo de divisão celular que resulta em duas células idênticas?";
            Q42.Resposta01 = "Meiose";
            Q42.Resposta02 = "Metabolismo";
            Q42.Resposta03 = "Mitose";
            Q42.Resposta04 = "Fermentação";
            Q42.Resposta05 = "Fusão nuclear";
            Q42.RespostaCorreta = "Mitose";
            Q42.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q42);

            var Q43 = new Questao();
            Q43.Pergunta = "Em que ano ocorreu a Revolução Francesa?";
            Q43.Resposta01 = "1759";
            Q43.Resposta02 = "1776";
            Q43.Resposta03 = "1789";
            Q43.Resposta04 = "1804";
            Q43.Resposta05 = "1848";
            Q43.RespostaCorreta = "1789";
            Q43.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q43);

            var Q44 = new Questao();
            Q44.Pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
            Q44.Resposta01 = "Thomas Jefferson";
            Q44.Resposta02 = "Abraham Lincoln";
            Q44.Resposta03 = "George Washington";
            Q44.Resposta04 = "John Adams";
            Q44.Resposta05 = "Franklin D. Roosevelt";
            Q44.RespostaCorreta = "George Washington";
            Q44.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q44);

            var Q45 = new Questao();
            Q45.Pergunta = "Qual é o órgão responsável por bombear o sangue no corpo humano?";
            Q45.Resposta01 = "Pulmões";
            Q45.Resposta02 = "Fígado";
            Q45.Resposta03 = "Coração";
            Q45.Resposta04 = "Cérebro";
            Q45.Resposta05 = "Rins";
            Q45.RespostaCorreta = "Coração";
            Q45.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q45);

            var Q46 = new Questao();
            Q46.Pergunta = "Qual é o menor planeta do sistema solar?";
            Q46.Resposta01 = "Vênus";
            Q46.Resposta02 = "Marte";
            Q46.Resposta03 = "Mercúrio";
            Q46.Resposta04 = "Netuno";
            Q46.Resposta05 = "Plutão";
            Q46.RespostaCorreta = "Mercúrio";
            Q46.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q46);

            var Q47 = new Questao();
            Q47.Pergunta = "Em que cidade fica localizado o Coliseu?";
            Q47.Resposta01 = "Paris";
            Q47.Resposta02 = "Londres";
            Q47.Resposta03 = "Atenas";
            Q47.Resposta04 = "Roma";
            Q47.Resposta05 = "Istambul";
            Q47.RespostaCorreta = "Roma";
            Q47.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q47);

            var Q48 = new Questao();
            Q48.Pergunta = "Quem descobriu o Brasil em 1500?";
            Q48.Resposta01 = "Pedro Álvares Cabral";
            Q48.Resposta02 = "Cristóvão Colombo";
            Q48.Resposta03 = "Vasco da Gama";
            Q48.Resposta04 = "Fernão de Magalhães";
            Q48.Resposta05 = "Bartolomeu Dias";
            Q48.RespostaCorreta = "Pedro Álvares Cabral";
            Q48.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q48);

            var Q49 = new Questao();
            Q49.Pergunta = "Qual o símbolo químico do ouro?";
            Q49.Resposta01 = "Ag";
            Q49.Resposta02 = "Au";
            Q49.Resposta03 = "Fe";
            Q49.Resposta04 = "Hg";
            Q49.Resposta05 = "Pb";
            Q49.RespostaCorreta = "Au";
            Q49.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q49);

            var Q50 = new Questao();
            Q50.Pergunta = "Qual é o maior oceano do mundo?";
            Q50.Resposta01 = "Oceano Atlântico";
            Q50.Resposta02 = "Oceano Índico";
            Q50.Resposta03 = "Oceano Pacífico";
            Q50.Resposta04 = "Oceano Ártico";
            Q50.Resposta05 = "Oceano Antártico";
            Q50.RespostaCorreta = "Oceano Pacífico";
            Q50.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q50);

            var Q51 = new Questao();
            Q51.Pergunta = "Qual é o maior planeta do sistema solar?";
            Q51.Resposta01 = "Terra";
            Q51.Resposta02 = "Saturno";
            Q51.Resposta03 = "Urano";
            Q51.Resposta04 = "Júpiter";
            Q51.Resposta05 = "Netuno";
            Q51.RespostaCorreta = "Júpiter";
            Q51.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q51);

            var Q52 = new Questao();
            Q52.Pergunta = "Em que ano começou a Primeira Guerra Mundial?";
            Q52.Resposta01 = "1912";
            Q52.Resposta02 = "1914";
            Q52.Resposta03 = "1916";
            Q52.Resposta04 = "1918";
            Q52.Resposta05 = "1920";
            Q52.RespostaCorreta = "1914";
            Q52.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q52);

            var Q53 = new Questao();
            Q53.Pergunta = "Qual é o estado brasileiro conhecido como 'Terra dos Pampas'?";
            Q53.Resposta01 = "Rio de Janeiro";
            Q53.Resposta02 = "Paraná";
            Q53.Resposta03 = "Santa Catarina";
            Q53.Resposta04 = "Rio Grande do Sul";
            Q53.Resposta05 = "Mato Grosso do Sul";
            Q53.RespostaCorreta = "Rio Grande do Sul";
            Q53.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q53);

            var Q54 = new Questao();
            Q54.Pergunta = "Qual é a estrela mais próxima da Terra?";
            Q54.Resposta01 = "Estrela Polar";
            Q54.Resposta02 = "Sirius";
            Q54.Resposta03 = "Sol";
            Q54.Resposta04 = "Betelgeuse";
            Q54.Resposta05 = "Proxima Centauri";
            Q54.RespostaCorreta = "Sol";
            Q54.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q54);

            var Q55 = new Questao();
            Q55.Pergunta = "Qual é o órgão responsável pela digestão no corpo humano?";
            Q55.Resposta01 = "Coração";
            Q55.Resposta02 = "Pulmões";
            Q55.Resposta03 = "Estômago";
            Q55.Resposta04 = "Fígado";
            Q55.Resposta05 = "Rins";
            Q55.RespostaCorreta = "Estômago";
            Q55.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q55);

            var Q56 = new Questao();
            Q56.Pergunta = "Em que cidade foram realizados os primeiros Jogos Olímpicos modernos?";
            Q56.Resposta01 = "Paris";
            Q56.Resposta02 = "Londres";
            Q56.Resposta03 = "Atenas";
            Q56.Resposta04 = "Roma";
            Q56.Resposta05 = "Berlim";
            Q56.RespostaCorreta = "Atenas";
            Q56.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q56);

            var Q57 = new Questao();
            Q57.Pergunta = "Em que ano caiu o Muro de Berlim?";
            Q57.Resposta01 = "1985";
            Q57.Resposta02 = "1987";
            Q57.Resposta03 = "1989";
            Q57.Resposta04 = "1991";
            Q57.Resposta05 = "1993";
            Q57.RespostaCorreta = "1989";
            Q57.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q57);

            var Q58 = new Questao();
            Q58.Pergunta = "Qual é o símbolo químico da água?";
            Q58.Resposta01 = "H2O";
            Q58.Resposta02 = "O2";
            Q58.Resposta03 = "CO2";
            Q58.Resposta04 = "NaCl";
            Q58.Resposta05 = "CH4";
            Q58.RespostaCorreta = "H2O";
            Q58.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q58);

            var Q59 = new Questao();
            Q59.Pergunta = "Em que continente fica a Austrália?";
            Q59.Resposta01 = "Ásia";
            Q59.Resposta02 = "Europa";
            Q59.Resposta03 = "América do Norte";
            Q59.Resposta04 = "Oceania";
            Q59.Resposta05 = "África";
            Q59.RespostaCorreta = "Oceania";
            Q59.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q59);

            var Q60 = new Questao();
            Q60.Pergunta = "Qual é o planeta conhecido como o 'Planeta Vermelho'?";
            Q60.Resposta01 = "Vênus";
            Q60.Resposta02 = "Marte";
            Q60.Resposta03 = "Júpiter";
            Q60.Resposta04 = "Saturno";
            Q60.Resposta05 = "Mercúrio";
            Q60.RespostaCorreta = "Marte";
            Q60.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q60);

            var Q61 = new Questao();
            Q61.Pergunta = "Qual o nome do compositor da famosa obra 'A Nona Sinfonia'?";
            Q61.Resposta01 = "Ludwig van Beethoven";
            Q61.Resposta02 = "Johann Sebastian Bach";
            Q61.Resposta03 = "Wolfgang Amadeus Mozart";
            Q61.Resposta04 = "Frédéric Chopin";
            Q61.Resposta05 = "Antonio Vivaldi";
            Q61.RespostaCorreta = "Ludwig van Beethoven";
            Q61.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q61);

            var Q62 = new Questao();
            Q62.Pergunta = "Qual é a moeda oficial do Japão?";
            Q62.Resposta01 = "Iene";
            Q62.Resposta02 = "Dólar";
            Q62.Resposta03 = "Euro";
            Q62.Resposta04 = "Libra Esterlina";
            Q62.Resposta05 = "Yuan";
            Q62.RespostaCorreta = "Iene";
            Q62.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q62);

            var Q63 = new Questao();
            Q63.Pergunta = "Qual é a fórmula química do gás carbônico?";
            Q63.Resposta01 = "CO";
            Q63.Resposta02 = "CO2";
            Q63.Resposta03 = "O2";
            Q63.Resposta04 = "H2O";
            Q63.Resposta05 = "CH4";
            Q63.RespostaCorreta = "CO2";
            Q63.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q63);

            var Q64 = new Questao();
            Q64.Pergunta = "Em que ano ocorreu o Descobrimento do Brasil?";
            Q64.Resposta01 = "1400";
            Q64.Resposta02 = "1450";
            Q64.Resposta03 = "1500";
            Q64.Resposta04 = "1550";
            Q64.Resposta05 = "1600";
            Q64.RespostaCorreta = "1500";
            Q64.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q64);

            var Q66 = new Questao();
            Q66.Pergunta = "Quem pintou a obra 'Mona Lisa'?";
            Q66.Resposta01 = "Vincent van Gogh";
            Q66.Resposta02 = "Pablo Picasso";
            Q66.Resposta03 = "Leonardo da Vinci";
            Q66.Resposta04 = "Claude Monet";
            Q66.Resposta05 = "Salvador Dalí";
            Q66.RespostaCorreta = "Leonardo da Vinci";
            Q66.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q66);

            var Q67 = new Questao();
            Q67.Pergunta = "Em que ano foi declarada a independência dos Estados Unidos?";
            Q67.Resposta01 = "1776";
            Q67.Resposta02 = "1789";
            Q67.Resposta03 = "1812";
            Q67.Resposta04 = "1848";
            Q67.Resposta05 = "1865";
            Q67.RespostaCorreta = "1776";
            Q67.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q67);

            var Q68 = new Questao();
            Q68.Pergunta = "Qual é o elemento mais abundante no universo?";
            Q68.Resposta01 = "Oxigênio";
            Q68.Resposta02 = "Hidrogênio";
            Q68.Resposta03 = "Nitrogênio";
            Q68.Resposta04 = "Carbono";
            Q68.Resposta05 = "Hélio";
            Q68.RespostaCorreta = "Hidrogênio";
            Q68.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q68);

            var Q69 = new Questao();
            Q69.Pergunta = "Quem escreveu 'Dom Quixote'?";
            Q69.Resposta01 = "Miguel de Cervantes";
            Q69.Resposta02 = "Gabriel García Márquez";
            Q69.Resposta03 = "William Shakespeare";
            Q69.Resposta04 = "Jorge Luis Borges";
            Q69.Resposta05 = "Mario Vargas Llosa";
            Q69.RespostaCorreta = "Miguel de Cervantes";
            Q69.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q69);

            var Q70 = new Questao();
            Q70.Pergunta = "Qual é o maior deserto do mundo?";
            Q70.Resposta01 = "Deserto de Gobi";
            Q70.Resposta02 = "Deserto do Saara";
            Q70.Resposta03 = "Deserto da Arábia";
            Q70.Resposta04 = "Deserto da Antártica";
            Q70.Resposta05 = "Deserto de Kalahari";
            Q70.RespostaCorreta = "Deserto da Antártica";
            Q70.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q70);

            var Q71 = new Questao();
            Q71.Pergunta = "Qual é o idioma mais falado no mundo?";
            Q71.Resposta01 = "Inglês";
            Q71.Resposta02 = "Chinês mandarim";
            Q71.Resposta03 = "Espanhol";
            Q71.Resposta04 = "Hindi";
            Q71.Resposta05 = "Árabe";
            Q71.RespostaCorreta = "Chinês mandarim";
            Q71.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q71);

            var Q72 = new Questao();
            Q72.Pergunta = "Qual é o maior oceano da Terra?";
            Q72.Resposta01 = "Oceano Atlântico";
            Q72.Resposta02 = "Oceano Índico";
            Q72.Resposta03 = "Oceano Pacífico";
            Q72.Resposta04 = "Oceano Ártico";
            Q72.Resposta05 = "Oceano Antártico";
            Q72.RespostaCorreta = "Oceano Pacífico";
            Q72.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q72);

            var Q73 = new Questao();
            Q73.Pergunta = "Qual é a principal fonte de energia do Sol?";
            Q73.Resposta01 = "Fissão nuclear";
            Q73.Resposta02 = "Combustão química";
            Q73.Resposta03 = "Fusão nuclear";
            Q73.Resposta04 = "Reação ácido-base";
            Q73.Resposta05 = "Oxidação";
            Q73.RespostaCorreta = "Fusão nuclear";
            Q73.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q73);

            var Q74 = new Questao();
            Q74.Pergunta = "Quem escreveu 'O Senhor dos Anéis'?";
            Q74.Resposta01 = "J.R.R. Tolkien";
            Q74.Resposta02 = "J.K. Rowling";
            Q74.Resposta03 = "George R.R. Martin";
            Q74.Resposta04 = "C.S. Lewis";
            Q74.Resposta05 = "H.P. Lovecraft";
            Q74.RespostaCorreta = "J.R.R. Tolkien";
            Q74.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q74);

            var Q75 = new Questao();
            Q75.Pergunta = "Qual é o maior animal do planeta?";
            Q75.Resposta01 = "Elefante";
            Q75.Resposta02 = "Tubarão-baleia";
            Q75.Resposta03 = "Baleia Azul";
            Q75.Resposta04 = "Orca";
            Q75.Resposta05 = "Girafa";
            Q75.RespostaCorreta = "Baleia Azul";
            Q75.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q75);

            var Q76 = new Questao();
            Q76.Pergunta = "Qual é o país mais populoso do mundo?";
            Q76.Resposta01 = "Índia";
            Q76.Resposta02 = "China";
            Q76.Resposta03 = "Estados Unidos";
            Q76.Resposta04 = "Indonésia";
            Q76.Resposta05 = "Paquistão";
            Q76.RespostaCorreta = "China";
            Q76.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q76);

            var Q77 = new Questao();
            Q77.Pergunta = "Qual é a língua oficial do Brasil?";
            Q77.Resposta01 = "Espanhol";
            Q77.Resposta02 = "Português";
            Q77.Resposta03 = "Inglês";
            Q77.Resposta04 = "Francês";
            Q77.Resposta05 = "Italiano";
            Q77.RespostaCorreta = "Português";
            Q77.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q77);

            var Q78 = new Questao();
            Q78.Pergunta = "Quem é conhecido como o 'Pai da Psicanálise'?";
            Q78.Resposta01 = "Sigmund Freud";
            Q78.Resposta02 = "Carl Jung";
            Q78.Resposta03 = "Wilhelm Wundt";
            Q78.Resposta04 = "Ivan Pavlov";
            Q78.Resposta05 = "Erik Erikson";
            Q78.RespostaCorreta = "Sigmund Freud";
            Q78.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q78);

            var Q79 = new Questao();
            Q79.Pergunta = "Qual é a fórmula química do metano?";
            Q79.Resposta01 = "CH4";
            Q79.Resposta02 = "C2H6";
            Q79.Resposta03 = "C3H8";
            Q79.Resposta04 = "C4H10";
            Q79.Resposta05 = "C5H12";
            Q79.RespostaCorreta = "CH4";
            Q79.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q79);

            var Q80 = new Questao();
            Q80.Pergunta = "Qual é a capital da França?";
            Q80.Resposta01 = "Paris";
            Q80.Resposta02 = "Londres";
            Q80.Resposta03 = "Madri";
            Q80.Resposta04 = "Roma";
            Q80.Resposta05 = "Berlim";
            Q80.RespostaCorreta = "Paris";
            Q80.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q80);

            var Q81 = new Questao();
            Q81.Pergunta = "Qual é o maior deserto quente do mundo?";
            Q81.Resposta01 = "Deserto do Saara";
            Q81.Resposta02 = "Deserto da Arábia";
            Q81.Resposta03 = "Deserto de Gobi";
            Q81.Resposta04 = "Deserto de Kalahari";
            Q81.Resposta05 = "Deserto de Mojave";
            Q81.RespostaCorreta = "Deserto do Saara";
            Q81.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q81);

            var Q82 = new Questao();
            Q82.Pergunta = "Quem inventou o telefone?";
            Q82.Resposta01 = "Alexander Graham Bell";
            Q82.Resposta02 = "Thomas Edison";
            Q82.Resposta03 = "Nikola Tesla";
            Q82.Resposta04 = "Michael Faraday";
            Q82.Resposta05 = "James Clerk Maxwell";
            Q82.RespostaCorreta = "Alexander Graham Bell";
            Q82.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q82);

            var Q83 = new Questao();
            Q83.Pergunta = "Qual é a segunda maior cidade dos Estados Unidos em termos de população?";
            Q83.Resposta01 = "New York";
            Q83.Resposta02 = "Los Angeles";
            Q83.Resposta03 = "Chicago";
            Q83.Resposta04 = "Houston";
            Q83.Resposta05 = "Philadelphia";
            Q83.RespostaCorreta = "Los Angeles";
            Q83.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q83);

            var Q84 = new Questao();
            Q84.Pergunta = "Qual é o metal mais leve conhecido?";
            Q84.Resposta01 = "Lítio";
            Q84.Resposta02 = "Boro";
            Q84.Resposta03 = "Hélio";
            Q84.Resposta04 = "Sódio";
            Q84.Resposta05 = "Magnésio";
            Q84.RespostaCorreta = "Lítio";
            Q84.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q84);

            var Q85 = new Questao();
            Q85.Pergunta = "Qual é o continente mais seco do mundo?";
            Q85.Resposta01 = "África";
            Q85.Resposta02 = "Antártica";
            Q85.Resposta03 = "Ásia";
            Q85.Resposta04 = "América do Sul";
            Q85.Resposta05 = "Oceania";
            Q85.RespostaCorreta = "Antártica";
            Q85.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q85);

            var Q86 = new Questao();
            Q86.Pergunta = "Qual é a principal função do sistema circulatório?";
            Q86.Resposta01 = "Respiração";
            Q86.Resposta02 = "Digestão";
            Q86.Resposta03 = "Transporte de nutrientes e oxigênio";
            Q86.Resposta04 = "Produção de hormônios";
            Q86.Resposta05 = "Excreção de resíduos";
            Q86.RespostaCorreta = "Transporte de nutrientes e oxigênio";
            Q86.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q86);

            var Q87 = new Questao();
            Q87.Pergunta = "Quem é o autor da teoria da relatividade?";
            Q87.Resposta01 = "Isaac Newton";
            Q87.Resposta02 = "Albert Einstein";
            Q87.Resposta03 = "Niels Bohr";
            Q87.Resposta04 = "Galileo Galilei";
            Q87.Resposta05 = "Michael Faraday";
            Q87.RespostaCorreta = "Albert Einstein";
            Q87.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q87);

            var Q88 = new Questao();
            Q88.Pergunta = "Qual é a capital da Itália?";
            Q88.Resposta01 = "Roma";
            Q88.Resposta02 = "Milão";
            Q88.Resposta03 = "Veneza";
            Q88.Resposta04 = "Florença";
            Q88.Resposta05 = "Nápoles";
            Q88.RespostaCorreta = "Roma";
            Q88.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q88);

            var Q89 = new Questao();
            Q89.Pergunta = "Qual é o maior lago da África?";
            Q89.Resposta01 = "Lago Vitória";
            Q89.Resposta02 = "Lago Tanganica";
            Q89.Resposta03 = "Lago Malawi";
            Q89.Resposta04 = "Lago Chad";
            Q89.Resposta05 = "Lago Edward";
            Q89.RespostaCorreta = "Lago Vitória";
            Q89.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q89);

            var Q90 = new Questao();
            Q90.Pergunta = "Qual é o principal gás responsável pelo efeito estufa?";
            Q90.Resposta01 = "Oxigênio";
            Q90.Resposta02 = "Hidrogênio";
            Q90.Resposta03 = "Dióxido de carbono";
            Q90.Resposta04 = "Metano";
            Q90.Resposta05 = "Nitrogênio";
            Q90.RespostaCorreta = "Dióxido de carbono";
            Q90.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q90);

            var Q91 = new Questao();
            Q91.Pergunta = "Qual é o maior sistema montanhoso do mundo?";
            Q91.Resposta01 = "Montanhas Rochosas";
            Q91.Resposta02 = "Andes";
            Q91.Resposta03 = "Himalaia";
            Q91.Resposta04 = "Alpes";
            Q91.Resposta05 = "Apalaches";
            Q91.RespostaCorreta = "Himalaia";
            Q91.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q91);

            var Q92 = new Questao();
            Q92.Pergunta = "Quem escreveu '1984'?";
            Q92.Resposta01 = "George Orwell";
            Q92.Resposta02 = "Aldous Huxley";
            Q92.Resposta03 = "Ray Bradbury";
            Q92.Resposta04 = "Margaret Atwood";
            Q92.Resposta05 = "H.G. Wells";
            Q92.RespostaCorreta = "George Orwell";
            Q92.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q92);

            var Q93 = new Questao();
            Q93.Pergunta = "Qual é a fórmula química da água?";
            Q93.Resposta01 = "H2O";
            Q93.Resposta02 = "CO2";
            Q93.Resposta03 = "NaCl";
            Q93.Resposta04 = "CH4";
            Q93.Resposta05 = "O2";
            Q93.RespostaCorreta = "H2O";
            Q93.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q93);

            var Q94 = new Questao();
            Q94.Pergunta = "Qual é o primeiro mês do ano no calendário gregoriano?";
            Q94.Resposta01 = "Janeiro";
            Q94.Resposta02 = "Fevereiro";
            Q94.Resposta03 = "Março";
            Q94.Resposta04 = "Abril";
            Q94.Resposta05 = "Maio";
            Q94.RespostaCorreta = "Janeiro";
            Q94.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q94);

            var Q95 = new Questao();
            Q95.Pergunta = "Qual é o país que mais produz café no mundo?";
            Q95.Resposta01 = "Brasil";
            Q95.Resposta02 = "Colômbia";
            Q95.Resposta03 = "Vietnã";
            Q95.Resposta04 = "Honduras";
            Q95.Resposta05 = "Etiópia";
            Q95.RespostaCorreta = "Brasil";
            Q95.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q95);

            var Q96 = new Questao();
            Q96.Pergunta = "Qual é a unidade de medida da temperatura no sistema internacional?";
            Q96.Resposta01 = "Fahrenheit";
            Q96.Resposta02 = "Kelvin";
            Q96.Resposta03 = "Celsius";
            Q96.Resposta04 = "Réaumur";
            Q96.Resposta05 = "Rankine";
            Q96.RespostaCorreta = "Kelvin";
            Q96.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q96);

            var Q97 = new Questao();
            Q97.Pergunta = "Qual é o nome do sistema solar em que a Terra está localizada?";
            Q97.Resposta01 = "Sistema Alpha";
            Q97.Resposta02 = "Sistema Andromeda";
            Q97.Resposta03 = "Sistema Sigma";
            Q97.Resposta04 = "Sistema Solar";
            Q97.Resposta05 = "Sistema Galáctico";
            Q97.RespostaCorreta = "Sistema Solar";
            Q97.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q97);

            var Q98 = new Questao();
            Q98.Pergunta = "Qual é o principal ingrediente do guacamole?";
            Q98.Resposta01 = "Tomate";
            Q98.Resposta02 = "Cebola";
            Q98.Resposta03 = "Abacate";
            Q98.Resposta04 = "Pimentão";
            Q98.Resposta05 = "Cenoura";
            Q98.RespostaCorreta = "Abacate";
            Q98.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q98);

            var Q99 = new Questao();
            Q99.Pergunta = "Qual é o nome do dispositivo usado para medir a pressão arterial?";
            Q99.Resposta01 = "Termômetro";
            Q99.Resposta02 = "Esfigmomanômetro";
            Q99.Resposta03 = "Oximetro";
            Q99.Resposta04 = "Estetoscópio";
            Q99.Resposta05 = "Glicosímetro";
            Q99.RespostaCorreta = "Esfigmomanômetro";
            Q99.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q99);

            var Q100 = new Questao();
            Q100.Pergunta = "Qual é o animal conhecido por ter o pescoço mais longo?";
            Q100.Resposta01 = "Girafa";
            Q100.Resposta02 = "Elefante";
            Q100.Resposta03 = "Zebra";
            Q100.Resposta04 = "Cavalo";
            Q100.Resposta05 = "Camelo";
            Q100.RespostaCorreta = "Girafa";
            Q100.ConfiguraEstruturaDesenho(labelpergunta, button1, button2, button3, button4, button5);
            ListaQuestoes.Add(Q100);


        }
        public void ProximaQuestao()
        {
            var numRandomico = Random.Shared.Next(0, ListaQuestoesRespondidas.Count);
            while (ListaQuestoesRespondidas.Contains(numRandomico))
                numRandomico = Random.Shared.Next(0, ListaQuestoesRespondidas.Count - 1);

            ListaQuestoesRespondidas.Add(numRandomico);
            QuestaoAtual = ListaQuestoes[numRandomico];
            QuestaoAtual.Desenhar();
        }
        public async void VerfiicaCorreto(int RespostaSelecionada)
        {
            if (QuestaoAtual.VerificaResposta(RespostaSelecionada))
            {
                await Task.Delay(1000);
                ProximaQuestao();
            }
        }
    }
}