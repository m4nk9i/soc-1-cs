using System.Text.Json;

namespace soc_1_cs;

public class Manager{

    public Match mat1;
 //   public Team t1,t2;  
    public List<League> l_leagues;
    public List<Player> l_players;  
    public Manager()
    {
        mat1=new Match();
   //     t1=new Team("krowa team");
   //     t2=new Team("owca team");
        l_players=new List<Player>();
        l_leagues=new List<League>();
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

    public void LoadLeagues(string ppath)
    {
        string tstr=File.ReadAllText(ppath);
        JsonDocument jsdoc=JsonDocument.Parse(tstr);
        JsonElement jselement=jsdoc.RootElement;
        JsonElement.ArrayEnumerator jsenum=jselement.EnumerateArray();
        while (jsenum.MoveNext())
        {
            League tleg=new League();
            if (jsenum.Current.GetProperty("G_name").GetString()!=null)
            {
                tleg.name=jsenum.Current.GetProperty("G_name").GetString();
            }
            tleg.ID=jsenum.Current.GetProperty("G_ID").GetInt16();
            l_leagues.Add(tleg);

        }

    }
    public League? findLeaguebyID(int pID)
    {
        League? tleg;
        tleg=l_leagues.Find(x=>x.ID==pID);
        return tleg;
    }

    public void LoadTeams(string ppath)
    {
        string tstr=File.ReadAllText(ppath);
        JsonDocument jsdoc=JsonDocument.Parse(tstr);
        JsonElement jselement=jsdoc.RootElement;
        JsonElement.ArrayEnumerator jsenum=jselement.EnumerateArray();
        while (jsenum.MoveNext())
        {
            Team tteam=new Team();
            if (jsenum.Current.GetProperty("T_name").GetString()!=null)
            {
                tteam.name=jsenum.Current.GetProperty("T_name").GetString();
            }
            tteam.ID=jsenum.Current.GetProperty("T_ID").GetInt16();
            int tlegid=jsenum.Current.GetProperty("T_group").GetInt16();            
            League tleg=findLeaguebyID(tlegid);
            tteam.league=tleg;
            tleg.l_teams.Add(tteam);

        }

    }

    public void loadData()
    {
        LoadPlayers(".\\data\\players.json");
        LoadLeagues(".\\data\\groups.json");
        LoadTeams(".\\data\\teams.json");
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

    public string ListLeagues()
    {
        string tstr="leagues list\r\n";
        foreach (League tleg in l_leagues)
        {
            tstr+=tleg.toStr(" ");
        }
        return tstr;
    }

    public void DumbInit()
    {
 //       t1.players.Add(l_players[0]);
 //       t1.players.Add(l_players[1]);
 //       t2.players.Add(l_players[2]);
 //       t2.players.Add(l_players[3]);
    }

}