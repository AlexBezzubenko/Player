using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

public class Test : QuestionCollection
    {
        int qcount = 0;
       
        public string Name { get; set; }

        public Test()
        {
            this.Name = "Общие вопросы";
            Add(new Question("Сколько планет в Солнечной системе", 1));
        }

        public Test(string name)
        {
            this.Name = name;

            Add(new Question("Пишется \"A\" на месте пропуска в словах", ++qcount));
            this[0].Answers.Add(new Answer("несг...раемый"));
            this[0].Answers.Add(new Answer("з...рница", true));
            this[0].Answers.Add(new Answer("раск...ленный", true));
            this[0].Answers.Add(new Answer("подр...стковый"));
            this[0].Answers.Add(new Answer("ст...рожил", true));
            

            Add(new Question("Пишется \"Е\" на месте всех пропусков в рядах:", ++qcount));
            this[1].Answers.Add(new Answer("пос..деть за столом; сл..паться в комок"));
            this[1].Answers.Add(new Answer("пр..кращение споров; скр..пить подписью", true));
            this[1].Answers.Add(new Answer("пр...стегнуть ремень;  ув...дший от жары"));
            this[1].Answers.Add(new Answer("пр..стрелять ружье; см..рение"));
            this[1].Answers.Add(new Answer("оскв...рнить память; разв...вается стяг", true));
            

            Add(new Question("Двойные согласные пишутся в словах:", ++qcount));
            this[2].Answers.Add(new Answer("ки(л,лл)ер", true));
            this[2].Answers.Add(new Answer("о(к/кк)упация", true));
            this[2].Answers.Add(new Answer("ра(с,сс)четливый человек"));
            this[2].Answers.Add(new Answer("мирово(з/зз)рение", true));
            this[2].Answers.Add(new Answer("заветре(н/нн)ый", true));
            
             
            Add(new Question("Пишется «О» на месте пропуска в словах:", ++qcount));
            this[3].Answers.Add(new Answer("крюч…к", true));
            this[3].Answers.Add(new Answer("ш...мпольный", true));
            this[3].Answers.Add(new Answer("возмещ...нный"));
            this[3].Answers.Add(new Answer("бельч..нок", true));
            this[3].Answers.Add(new Answer("еж..вые рукавицы", true));
            
            
            Add(new Question("Пишется мягкий знак на месте пропуска:", ++qcount));
            this[4].Answers.Add(new Answer("лесная глуш..", true));
            this[4].Answers.Add(new Answer("отвлеч.. внимание", true));
            this[4].Answers.Add(new Answer("пять краж.."));
            this[4].Answers.Add(new Answer("монтаж.."));
            this[4].Answers.Add(new Answer("сверх..яростный"));
           
        }
        public List<Question> ToList()
        {
            return this.ToList<Question>();
        }

    }
