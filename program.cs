 using System;
class Animal
{
    public string ruido;
    
    static void respirar()
    {
        Console.WriteLine("los animales respiran ademas de eso");
        
    }
    public void accion()
    {
        Console.WriteLine(" y " + ruido);
    }
    static void Main()
    {
        Animal pez= new Animal();
        Animal perro= new Animal();
        Animal gato= new Animal();
        
        pez.ruido= "los peces nadan";
        perro.ruido="los perros ladran";
        gato.ruido="los gatos maullan";
        
        Animal.respirar();
        pez.accion();
        perro.accion();
        gato.accion();
        
    }
}
