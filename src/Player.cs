namespace soc_1_cs;

public class Player
{
    int ID;
    public string name;
    float age;
    public Player()
    {

    }
    public string toStr(string pindent)
    {
        string tstr="";
        tstr+=pindent+this.name+ " ("+this.ID+") - "+this.age +"\n";
        return tstr;
    }
}
