namespace soc_1_cs;

public class Team
{
    string name;
    List<Player> players;
    public Team()
    {
        players=new List<Player>();

    }

    public string toStr(string pindent)
    {
        string tstr="";
        tstr+=pindent+" === "+this.name+" === \n";
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