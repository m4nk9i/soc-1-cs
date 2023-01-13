namespace soc_1_cs;

public class Team
{
    string name;
    public List<Player> players;
    public Team():this(" -=*=- ")
    {     

    }

    public Team(string pstr)
    {
        players=new List<Player>();
        this.name=pstr;
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