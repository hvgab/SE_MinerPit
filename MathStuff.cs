float GetLengthOfVector(int blocks_x, int blocks_y)
        // x = number of blocks in x direction
        // y = number of blocks in y direction
        {
            Vector vector = new Vector(blocks_x * 2.5, blocks_y * 2.5);
            Double lengthResult = vector.Length;
            return lengthResult;
        }

        float GetPistonLengthSetting(float vectorLength)
        {
            // -2.5 because each point is in the middle of a block 2.5m wide.
            float pistonLength = (vectorLength - 2.5 - (NumOfHorizontalPistons * PISTON_LENGTH_IN_METERS)) / NumOfHorizontalPistons );
            return pistonLength;
        }

        float GetAngleOfVector(int blocks_x, int blocks_y)
        {
            Vector startpos = new Vector(0, 1);
            Vector vector = new Vector(blocks_x * 2.5, blocks_y * 2.5);
            float angleBetween = vector.AngleBetween(startpos, vector);
            return angleBetween;
        }

        float GetPistonLengthSetting(int x, int y)
        {
            float vectorLength = GetLengthOfVector(x, y);
            float pistonLength = (vectorLength - 2.5 - (NumOfHorizontalPistons * PISTON_LENGTH_IN_METERS)) / NumOfHorizontalPistons );
            return pistonLength;
        }