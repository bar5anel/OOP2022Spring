﻿using System.Diagnostics;
public class MyStackGeneric<T>
{
    private T[] _data;
    private int _capacity = 16;
    private int _count = 0;
    public MyStackGeneric()
    {
        _data = new T[_capacity];
    }

    public void Push(T value)
    {
        Debug.WriteLine($"Incerc sa adaug valoarea {value} in stiva");
        if (Count == Capacity)
        {
            _capacity *= 2;
            T[] vs = new T[_capacity];
            for (int i = 0; i < Count; i++)
                vs[i] = _data[i];
            _data = vs;
            Debug.WriteLine("Capacitatea stivei se dubleaza");
        }
        _data[Count] = value;
        _count++;
    }

    public T Peek()
    {
        if (Count > 0)
        {
            return _data[Count - 1];
        }
        else
        {
            throw new StackEmptyException("Am incercat sa examinez elementul din varful unei stive goale");
        }
    }

    public T Pop()
    {

        if (Count > 0)
        {
            _count--;
            Debug.WriteLine($"Se elimina din stiva elementul {_data[_count]}");
            return _data[_count];
        }
        else
        {
            throw new StackEmptyException("Am incercat sa elimin un element din stiva goala");
        }
    }

    public int Count
    {
        get
        {
            return _count;
        }
    }
    public int Capacity
    {
        get
        {
            return _capacity;
        }
    }
}