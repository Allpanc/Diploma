[System.Serializable]
public class Institute
{
    public string _name;
    public Profession[] _bachelorPrograms;
    public Profession[] _specialistPrograms;
    public string _contacts;

    public Institute(string name, Profession[] bachelorPrograms, Profession[] specialistPrograms, string contacts)
    {
        _name = name;
        _bachelorPrograms = bachelorPrograms;
        _specialistPrograms = specialistPrograms;
        _contacts = contacts;
    }
}

[System.Serializable]
public class Profession
{
    public string _name;
    public string[] _entryExams;

    public Profession(string name, string[] entryExams)
    {
        _name = name;
        _entryExams = entryExams;
    }

    public override string ToString()
    {
        string str = " — " + _name + "\nВступительные испытания (ЕГЭ):\n";
        for (int i = 0; i < _entryExams.Length; i++)
        {
            str += _entryExams[i];
            if (i != _entryExams.Length - 1)
                str += ", ";
        }
        return str;
    }
}