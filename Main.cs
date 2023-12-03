class Main{

    private string name;

    public string Name{
        get{return name;}
    }
    public Main(string name){
        this.name = name;
    }

    public static void Greet(){
        Console.WriteLine("Hello");
    }
}