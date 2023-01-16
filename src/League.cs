using soc_1_cs;

public class League
{
    public List<Team> l_teams;
    public string name;
    public int ID;
    public League()
    {
        l_teams=new List<Team>();
        name=" @@@ ";
    }

    public string toStr(string indent)
    {
        string tstr="";
        tstr+=indent+name+" ("+l_teams.Count+"):\r\n";
        foreach (Team tteam in l_teams)
        {
            tstr+=indent+"-   "+tteam.name+"\r\n";
        }
        return tstr;
    }
}