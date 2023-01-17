namespace soc_1_cs;

public class Team:IComparable
{
    public string name;
    public List<Player> l_players;
    public List<int> l_points;
    public int ID;
    public League league;
    public Team():this(" -=*=- ")
    {     

    }

    public Team(string pstr)
    {
        name=pstr;
        l_players=new List<Player>();
        l_points=new List<int>();

    }

    public string toStr(string pindent)
    {
        string tstr="";
        tstr+=pindent+" === "+this.name+" === \r\n";
        foreach (Player tpl in this.l_players)
        {
            tstr+=tpl.toStr(pindent+"  ");
        }
        return tstr;
    }

    public string toStrShort(string pindent)
    {
        string tstr="";
        tstr+=pindent+" === "+this.name+" === \n";
        foreach (Player tpl in this.l_players)
        {
            tstr+=pindent+tpl.name;
        }
        return tstr;
    }

    public int CompareTo(object? tteam)
    {
        //Team tteam1=tteam as Team;
        return this.name.CompareTo(((Team)tteam).name);
    }

    public string points()
    {
        string tstr="";
        int tpo=0;
        foreach(int i in l_points)
        {
            tpo+=i;
        }
        tstr=tpo.ToString();
        return tstr;
    }

}