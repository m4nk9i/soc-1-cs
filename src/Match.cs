namespace soc_1_cs;
public class Match{
    public Match()
    {

    }

    public void Draw( Graphics gr)
    {
        gr.Clear(Color.White);
        gr.DrawLine(new Pen(Color.Black,3),10,10,30,30);

    }

}
