using UnityEngine;
using System.Collections;

public class Block
{

    public Block(int type,int direction)
    {
        //init shapes
        switch (type)
        {
            //
            //  _ _ _ _
            // |_|_|_|_|
            //
            case 0:
                switch (direction)
                {
                    case 0:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            1, 1, 1, 1,
                            0, 0, 0, 0,
                            0, 0, 0, 0
                        };
                        break;
                    case 1:
                        this.position = new int[] {
                            0, 1, 0, 0,
                            0, 1, 0, 0,
                            0, 1, 0, 0,
                            0, 1, 0, 0
                        };
                        break;
                    case 2:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            1, 1, 1, 1,
                            0, 0, 0, 0,
                            0, 0, 0, 0
                        };
                        break;
                    case 3:
                        this.position = new int[] {
                            0, 1, 0, 0,
                            0, 1, 0, 0,
                            0, 1, 0, 0,
                            0, 1, 0, 0
                        };
                        break;
                }
                break;
            //  _ _
            // |_|_|
            // |_|_|
            //
            case 1:
                this.position = new int[] {
                    0, 0, 0, 0,
                    0, 1, 1, 0,
                    0, 1, 1, 0,
                    0, 0, 0, 0
                };
                break;
            //      _
            //  _ _|_|
            // |_|_|_|
            //
            case 2:
                switch (direction)
                {
                    case 0:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            0, 0, 0, 1,
                            0, 1, 1, 1,
                            0, 0, 0, 0
                        };
                        break;
                    case 1:
                        this.position = new int[] {
                            0, 0, 1, 0,
                            0, 0, 1, 0,
                            0, 0, 1, 1,
                            0, 0, 0, 0
                        };
                        break;
                    case 2:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            0, 1, 1, 1,
                            0, 1, 0, 0,
                            0, 0, 0, 0
                        };
                        break;
                    case 3:
                        this.position = new int[] {
                            0, 1, 1, 0,
                            0, 0, 1, 0,
                            0, 0, 1, 0,
                            0, 0, 0, 0
                        };
                        break;
                }
                break;
            //    _
            //  _|_|_
            // |_|_|_|
            //
            case 3:
                switch (direction)
                {
                    case 0:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            0, 0, 1, 0,
                            0, 1, 1, 1,
                            0, 0, 0, 0
                        };
                        break;
                    case 1:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            0, 0, 1, 0,
                            0, 0, 1, 1,
                            0, 0, 1, 0
                        };
                        break;
                    case 2:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            0, 0, 0, 0,
                            0, 1, 1, 1,
                            0, 0, 1, 0
                        };
                        break;
                    case 3:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            0, 0, 1, 0,
                            0, 1, 1, 0,
                            0, 0, 1, 0
                        };
                        break;
                }
                break;
            //  _    
            // |_|_ _
            // |_|_|_|
            //
            case 4:
                switch (direction)
                {
                    case 0:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            0, 1, 0, 0,
                            0, 1, 1, 1,
                            0, 0, 0, 0
                        };
                        break;
                    case 1:
                        this.position = new int[] {
                            0, 0, 1, 1,
                            0, 0, 1, 0,
                            0, 0, 1, 0,
                            0, 0, 0, 0
                        };
                        break;
                    case 2:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            0, 1, 1, 1,
                            0, 0, 0, 1,
                            0, 0, 0, 0
                        };
                        break;
                    case 3:
                        this.position = new int[] {
                            0, 0, 1, 0,
                            0, 0, 1, 0,
                            0, 1, 1, 0,
                            0, 0, 0, 0
                        };
                        break;
                }
                break;
            //  _ _
            // |_|_|_
            //   |_|_|
            //
            case 5:
                switch (direction)
                {
                    case 0:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            0, 1, 1, 0,
                            0, 0, 1, 1,
                            0, 0, 0, 0
                        };
                        break;
                    case 1:
                        this.position = new int[] {
                            0, 0, 0, 1,
                            0, 0, 1, 1,
                            0, 0, 1, 0,
                            0, 0, 0, 0
                        };
                        break;
                    case 2:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            0, 1, 1, 0,
                            0, 0, 1, 1,
                            0, 0, 0, 0
                        };
                        break;
                    case 3:
                        this.position = new int[] {
                            0, 0, 0, 1,
                            0, 0, 1, 1,
                            0, 0, 1, 0,
                            0, 0, 0, 0
                        };
                        break;
                }
                break;
            //    _ _
            //  _|_|_|
            // |_|_|
            //
            case 6:
                switch (direction)
                {
                    case 0:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            0, 0, 1, 1,
                            0, 1, 1, 0,
                            0, 0, 0, 0
                        };
                        break;
                    case 1:
                        this.position = new int[] {
                            0, 0, 1, 0,
                            0, 0, 1, 1,
                            0, 0, 0, 1,
                            0, 0, 0, 0
                        };
                        break;
                    case 2:
                        this.position = new int[] {
                            0, 0, 0, 0,
                            0, 0, 1, 1,
                            0, 1, 1, 0,
                            0, 0, 0, 0
                        };
                        break;
                    case 3:
                        this.position = new int[] {
                            0, 0, 1, 0,
                            0, 0, 1, 1,
                            0, 0, 0, 1,
                            0, 0, 0, 0
                        };
                        break;
                }
                break;
        }
        this.type = type;
        this.direction = direction;
    }


    /// <summary>
    /// 4*4 array position,from left to right,up to down
    /// </summary>
    public int[] position
    {
        get; set;
    }

    /// <summary>
    /// the type of block
    /// </summary>
    public int type
    {
        get; set;
    }

    /// <summary>
    /// the direction of block
    /// </summary>
    public int direction
    {
        get; set;
    }

    /// <summary>
    /// rotate clockwise
    /// </summary>
    public void clockwise()
    {
        if(this.direction == 3)
        {
            this.direction = 0;
        }
        else
        {
            this.direction++;
        }
    }

    /// <summary>
    /// rotate anticlockwise
    /// </summary>
    public void counterClockwise()
    {
        if (this.direction == 0)
        {
            this.direction = 3;
        }
        else
        {
            this.direction--;
        }
    }




}
