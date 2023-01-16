namespace soc_1_cs;

public class Team
{
    public string name;
    public List<Player> players;
    public int ID;
    public League league;
    public Team():this(" -=*=- ")
    {     

    }



    public Team(string pstr)
    {
        name=pstr;
        players=new List<Player>();

    }

    public string toStr(string pindent)
    {
        string tstr="";
        tstr+=pindent+" === "+this.name+" === \r\n";
        foreach (Player tpl in this.players)
        {
            tstr+=tpl.toStr(pindent+"  ");
        }
        return tstr;
    }

    public string toStrShort(string pindent)
    {
        string tstr="";
        tstr+=pindent+" === "+this.name+" === \n";
        foreach (Player tpl in this.players)
        {
            tstr+=pindent+tpl.name;
        }
        return tstr;
    }

}