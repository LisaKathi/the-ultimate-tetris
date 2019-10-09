using System;

namespace BlazorTetris.Logic
{
    public class Pieces
    {
        public static readonly string __ = string.Empty;
        public static readonly string IC = "I";
        public static readonly string JC = "J";
        public static readonly string LC = "L";
        public static readonly string OC = "O";
        public static readonly string SC = "S";
        public static readonly string TC = "T";
        public static readonly string ZC = "Z";

        public static readonly string[,] IH = {
            { IC, IC, IC, IC }
        };
        public static readonly string[,] IV = {
            { IC },
            { IC },
            { IC },
            { IC }
        };
        public static readonly string[,] JH = {
            { JC, JC, JC },
            { __, __, JC }
        };
        public static readonly string[,] JV = {
            
            { __, JC },
            { __, JC },
            { JC, JC }
        };
        public static readonly string[,] JH2 = {
            { JC, __, __ },
            { JC, JC, JC }
        };
        public static readonly string[,] JV2 = {

            { JC, JC },
            { JC, __ },
            { JC, __ }
        };
        public static readonly string[,] LV = {
            { LC, __ },
            { LC, __ },
            { LC, LC }
        };
        public static readonly string[,] LH = {
            { __, __, LC },
            { LC, LC, LC }
        };
        public static readonly string[,] LV2 = {
            { LC, LC },
            { __, LC },
            { __, LC }
        };
        public static readonly string[,] LH2 = {
            { LC, LC, LC },
            { LC, __, __ }
        };
        public static readonly string[,] O = {
            { OC, OC },
            { OC, OC },
        };
        public static readonly string[,] SV = {
            { SC, __ },
            { SC, SC },
            { __, SC }
        };
        public static readonly string[,] SH = {
            { __, SC, SC },
            { SC, SC, __ },  
        };
        public static readonly string[,] ZV = {
            { __, ZC },
            { ZC, ZC },
            { ZC, __ }
        };
        public static readonly string[,] ZH = {
            { ZC, ZC, __ },
            { __, ZC, ZC },


        };
        public static readonly string[,] TH = {
            { TC, TC, TC },
            { __, TC, __ },


        };
        public static readonly string[,] TV = {
            { TC, __ },
            { TC, TC },
            { TC, __ },

        };
        public static readonly string[,] TH2 = {
            { __, TC, __ },
            { TC, TC, TC },


        };
        public static readonly string[,] TV2 = {
            { __, TC },
            { TC, TC },
            { __, TC },

        };
        public static readonly string[][,] AvailablePieces = new[] { IV, IH, JV, JH, JV2, JH2, LV2, LH2, LH, LV, TV, TV2, TH, TH2, ZV, ZH, SV, SH, O};

        public static string[,] GetRandomPiece()
        {
            var random = new Random();
            return (string[,])AvailablePieces[random.Next(0, AvailablePieces.Length)].Clone();
        }
    }
}