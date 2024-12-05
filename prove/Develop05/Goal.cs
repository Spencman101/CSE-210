using System;

abstract class Goal
{

    private int _points;
    
    private string _name;

    private string _task;

    private Boolean _complete;

    private void IsComplete()
    {

    }

    public abstract int RecordEvent();

    private virtual void Display()
    {

    }

    private virtual void Create()
    {

    }
}