namespace soc_1_cs;

public class Player
{
    int ID;
    public string name;
    float age;
    public Player()
    {
        this.name="";
        this.ID=0;
        this.age=2;

    }
    public string toStr(string pindent)
    {
        string tstr="";
        tstr+=pindent+this.name+ " ("+this.ID+") - "+this.age +"\n";
        return tstr;
    }
}
