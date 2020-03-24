/// <summary>
/// 
/// </summary>
public static class BouncingBall
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="h"></param>
    /// <param name="bounce"></param>
    /// <param name="window"></param>
    /// <returns></returns>
    public static int bouncingBall(double h, double bounce, double window) {
        if(h <= 0 || bounce <=0 || bounce >= 1 || window >= h) return -1;
        int bounceCount = 0;
        while(h > window){
            bounceCount += 1;
            h = h * bounce;
            if(h > window){
                bounceCount += 1;
            }
        }
        return bounceCount;
    }
}