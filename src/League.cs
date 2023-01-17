using soc_1_cs;

public class League
{

    static private int[,,] roundrobin = new int[17, 9, 2]{
            {{18,1},{2,17},{3,16},{4,15},{5,14},{6,13},{7,12},{8,11},{9,10}},
            {{10,18},{11,9},{12,8},{13,7},{14,6},{15,5},{16,4},{17,3},{1,2}},
            {{18,2},{3,1},{4,17},{5,16},{6,15},{7,14},{8,13},{9,12},{10,11}},
            {{11,18},{12,10},{13,9},{14,8},{15,7},{16,6},{17,5},{1,4},{2,3}},
            {{18,3},{4,2},{5,1},{6,17},{7,16},{8,15},{9,14},{10,13},{11,12}},
            {{12,18},{13,11},{14,10},{15,9},{16,8},{17,7},{1,6},{2,5},{3,4}},
            {{18,4},{5,3},{6,2},{7,1},{8,17},{9,16},{10,15},{11,14},{12,13}},
            {{13,18},{14,12},{15,11},{16,10},{17,9},{1,8},{2,7},{3,6},{4,5}},
            {{5,18},{6,4},{7,3},{8,2},{9,1},{10,17},{11,16},{12,15},{13,14}},
            {{18,14},{15,13},{16,12},{17,11},{1,10},{2,9},{3,8},{4,7},{5,6}},
            {{6,18},{7,5},{8,4},{9,3},{10,2},{11,1},{12,17},{13,16},{14,15}},
            {{18,15},{16,14},{17,13},{1,12},{2,11},{3,10},{4,9},{5,8},{6,7}},
            {{7,18},{8,6},{9,5},{10,4},{11,3},{12,2},{13,1},{14,17},{15,16}},
            {{18,16},{17,15},{1,14},{2,13},{3,12},{4,11},{5,10},{6,9},{7,8}},
            {{8,18},{9,7},{10,6},{11,5},{12,4},{13,3},{14,2},{15,1},{16,17}},
            {{18,17},{1,16},{2,15},{3,14},{4,13},{5,12},{6,11},{7,10},{8,9}},
            {{9,18},{10,8},{11,7},{12,6},{13,5},{14,4},{15,3},{16,2},{17,1}}
        };
    public List<Team> l_teams;
    public string name;
    public int ID;
    //public Tournament tour1;
    public int currentround=0;
    public League()
    {
        l_teams=new List<Team>();
        name=" @@@ ";
    }

    public void SortTeams()
    {
        l_teams.Sort();
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

    public string OneRoundMatches(int ptournr)
    {
        string tstr="";    
        Match tmat1;
        Team tteam1,tteam2;        
        for(int i=0;i<9;i++)
        {
 
            if ((roundrobin[ptournr,i,0]<=l_teams.Count) 
             && (roundrobin[ptournr,i,1]<=l_teams.Count)) 
             {
                tteam1=l_teams[roundrobin[ptournr,i,0]-1];
                tteam2=l_teams[roundrobin[ptournr,i,1]-1];

                tmat1=new Match(tteam1,tteam2);
                tmat1.Play();
                tstr+="("+(roundrobin[ptournr,i,0]-1)+","+(roundrobin[ptournr,i,1]-1)+") ";
                tstr+=tmat1.ExtendedResult()+"\r\n";
             }

        }
        return tstr;
    }
    public string NextRound()
    {   
        string tstr="";
        currentround++;
        if (currentround<=9)
        {
            tstr=OneRoundMatches(currentround);
        }
        return tstr;
    }    
}