namespace DbArts
{
    public class Set
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool islegendary { get; set; }
        public string effect2 { get; set; }
        public string effect4 { get; set; }
    }

    public class State
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool issubst { get; set; }
    }

    public class StateIsUpState
    {
        public int id { get; set; }
        public bool isupstate { get; set; }
    }

    public class Type
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class TypeUpValue : IDisposable
    {
        public int id { get; set; }
        public int idtype { get; set; }
        public int idupstate { get; set; }

        public void Dispose() { id = 0; idtype = 0; idupstate = 0; }
    }

    public class UpStateValueLeg
    {
        public int id { get; set; }
        public int idstate { get; set; }
        public double value { get; set; }
        public int level { get; set; }
    }

    public class Art
    {
        public int id { get; set; }
        public int idtype { get; set; }
        public int idupstate { get; set; }
        public int idset { get; set; }
        public double critmass { get; set; }
        public double est { get; set; }
        public int level { get; set; }
        public bool isgold { get; set; }
    }

    public class Substates
    {
        public int id { get; set; }
        public int idart { get; set; }
        public int idstate { get; set; }
        public double value { get; set; }
    }
}
