using System;

abstract class Checklist : Goal
{

    private int points;

    private string name;

    private Boolean complete;

    private string task;

    private int CompletetionPoints;

    private int ChecklistNum;


    private Boolean IsComplete()
    {

    }

    private abstract void RecordEvent()
    {

    }

    private virtual void Display()
    {

    }

    private virtual void Create()
    {
        
    }
}