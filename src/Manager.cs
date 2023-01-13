using System.Text.Json;

namespace soc_1_cs;

public class Manager{

    public Match mat1;
    public Team t1,t2;  

    public List<Player> l_players;  
    public Manager()
    {
        mat1=new Match();
        t1=new Team("krowa team");
        t2=new Team("owca team");
        l_players=new List<Player>();
    }

    public void LoadPlayers(string ppath)
    {
        string tstr=File.ReadAllText(ppath);
        JsonDocument jsdoc=JsonDocument.Parse(tstr);
        JsonElement jselement=jsdoc.RootElement;
        JsonElement.ArrayEnumerator jsenum=jselement.EnumerateArray();
        while (jsenum.MoveNext())
        {
            Player tpl=new Player();
            if (jsenum.Current.GetProperty("name").GetString()!=null)
            {
                tpl.name=jsenum.Current.GetProperty("name").GetString();
            }
            tpl.ID=jsenum.Current.GetProperty("ID").GetInt16();
            l_players.Add(tpl);

        }
        
    }

    public string ListPlayers()
    {
        string tstr="player list\r\n";
        foreach (Player tpl in l_players)
        {
            tstr+=tpl.toStr(" ");
        }
        return tstr;
    }

    public void DumbInit()
    {
        t1.players.Add(l_players[0]);
        t1.players.Add(l_players[1]);
        t2.players.Add(l_players[2]);
        t2.players.Add(l_players[3]);
    }

}