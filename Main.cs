class Main{

    private string name;
    
    #region propertie
    public string Name{
        get{return name;}
    }

    #endregion

    
    public Main(string name){
        this.name = name;
    }

    public static void Greet(){
        Console.WriteLine("new hello git with changes");
    }
}