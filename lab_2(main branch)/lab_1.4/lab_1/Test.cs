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
            this.Name = "����� �������";
            Add(new Question("������� ������ � ��������� �������", 1));
        }

        public Test(string name)
        {
            this.Name = name;

            Add(new Question("������� \"A\" �� ����� �������� � ������", ++qcount));
            this[0].Answers.Add(new Answer("����...������"));
            this[0].Answers.Add(new Answer("�...�����", true));
            this[0].Answers.Add(new Answer("����...������", true));
            this[0].Answers.Add(new Answer("����...�������"));
            this[0].Answers.Add(new Answer("��...�����", true));
            

            Add(new Question("������� \"�\" �� ����� ���� ��������� � �����:", ++qcount));
            this[1].Answers.Add(new Answer("���..���� �� ������; ��..������ � �����"));
            this[1].Answers.Add(new Answer("��..�������� ������; ���..���� ��������", true));
            this[1].Answers.Add(new Answer("��...�������� ������;  ��...���� �� ����"));
            this[1].Answers.Add(new Answer("��..�������� �����; ��..�����"));
            this[1].Answers.Add(new Answer("����...����� ������; ����...������ ����", true));
            

            Add(new Question("������� ��������� ������� � ������:", ++qcount));
            this[2].Answers.Add(new Answer("��(�,��)��", true));
            this[2].Answers.Add(new Answer("�(�/��)������", true));
            this[2].Answers.Add(new Answer("��(�,��)�������� �������"));
            this[2].Answers.Add(new Answer("������(�/��)�����", true));
            this[2].Answers.Add(new Answer("�������(�/��)��", true));
            
             
            Add(new Question("������� �λ �� ����� �������� � ������:", ++qcount));
            this[3].Answers.Add(new Answer("������", true));
            this[3].Answers.Add(new Answer("�...��������", true));
            this[3].Answers.Add(new Answer("������...����"));
            this[3].Answers.Add(new Answer("�����..���", true));
            this[3].Answers.Add(new Answer("��..��� ��������", true));
            
            
            Add(new Question("������� ������ ���� �� ����� ��������:", ++qcount));
            this[4].Answers.Add(new Answer("������ ����..", true));
            this[4].Answers.Add(new Answer("������.. ��������", true));
            this[4].Answers.Add(new Answer("���� ����.."));
            this[4].Answers.Add(new Answer("������.."));
            this[4].Answers.Add(new Answer("�����..��������"));
           
        }
        public List<Question> ToList()
        {
            return this.ToList<Question>();
        }

    }
