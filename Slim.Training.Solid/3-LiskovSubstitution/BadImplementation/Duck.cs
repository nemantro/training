namespace Slim.Training.Solid._3_LiskovSubstitution.BadImplementation;

public class Duck : Bird
{
    public string Swim()
    {
        return "I can swim too";
    }
}