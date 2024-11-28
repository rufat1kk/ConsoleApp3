int[] xa = new int[11];
Random rnd = new Random();

xa[0] = 7;
for (int i = 1; i < xa.Length; i++)
{
    xa[i] = rnd.Next(0, 9);
}
Console.Write('+'+xa[0] + " ("+xa[1]+ xa[2] + xa[3] + ") "+xa[4]+xa[5]+xa[6]+ " - "+xa[7]+xa[8]+xa[9]+xa[10] + "\n" + "\n");

