namespace soc_1_cs;
public class Match{
    private Team team1;
    private Team team2;
    private int goals1=0;
    private int goals2=0;

    public static Random rnd;



    public Match(Team pteam1,Team pteam2)
    {
        team1=pteam1;
        team2=pteam2;
        if (rnd==null)
        {
            rnd=new Random();
        }
    }

    public void Play()
    {
        goals1=rnd.Next(5);
        goals2=rnd.Next(5);
        int[] tpoints=  Points();
        team1.l_points.Add(tpoints[0]);
        team2.l_points.Add(tpoints[1]);
    }

    public string Result()
    {
        string tstr=goals1+":"+goals2;
        return tstr;
    }

    public string ExtendedResult()
    {
        string tstr=team1.name+ " ("+goals1+":"+goals2+") "+team2.name;
        return tstr;
    }

    public int[] Points()
    {
        int[] tpoints=new int[2];
        tpoints[0]=1;
        tpoints[1]=1;
        if (goals1<goals2) 
        {
            tpoints[1]=3;
            tpoints[0]=0;
        }
        if (goals2<goals1) 
        {
            tpoints[1]=0;
            tpoints[0]=3;
        }
        return tpoints;
    }

    public void Draw( Graphics gr)
    {
        gr.Clear(Color.White);
        gr.DrawLine(new Pen(Color.Black,3),10,10,30,30);

    }

}
