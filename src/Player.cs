namespace soc_1_cs;

public class Player
{
    public int ID;
    public string name;
    public float age;
    public Player():this(" [x] ")
    {

    }

    public Player(string pname)
    {
        name=pname;
    }
    
    public string toStr(string pindent)
    {
        
        string tstr="";
        tstr+=pindent+this.name+ " ("+this.ID+") - "+this.age +"\r\n";
        return tstr;
    }
}
