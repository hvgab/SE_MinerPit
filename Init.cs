
class Init{

    // Block definitions

    List<IMyAdvancedRotor> Rotors IMyAdvancedRotor;
    List<IMyPiston> HorizontalPistons IMyPiston;
    List<IMyPiston> VerticalPistonsDown IMyPiston;
    List<IMyPiston> VerticalPistonsUp IMyPiston;

    List<Pit> Pits Pit;
    

    // Find Rotors
    // Find Horizontal Pistons
    // Find Vertical Pistons Down
    // Find Vertical Pistons Up
    int GetMaxXYSetting()
        {
            // Get max X on 0 degrees
            int x = 0;
            int test_y = 1;
            int max_y = 0;
            while (true)
            {
                float length = GetPistonLengthSetting(x, test_y);
                if (length > 10.0)
                {
                    return max_y;
                }
                if (length < 10 && length > max_y)
                {
                    max_y = length;
                    test_y += 1;
                }
            }
        }

    List<> GetCoordsWithinRange(int max_y)
        {
            Array coords;

        }
         // Get coords within length
         coords [] 

            //sort coords smallest  length of pistons, smallest angle
         maxLength = X
         minLength = X * -1
         
         for i=minLength
                for j = minLength

         -2, -2
         -2 -1
         -2 0
         -2 1
         -2 2
         -1 -2
         -1 -1
         -1 0
         -0 1
         etc
}