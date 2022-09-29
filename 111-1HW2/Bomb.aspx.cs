using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW2
{
    public partial class Bomb1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            char[,] Ca_Map = new char[10, 10];
            int[] ia_MIndex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };

            for (int i_Row = 0; i_Row < 10; i_Row++)
            {
                for (int i_Col = 0; i_Col < 10; i_Col++)
                {
                    Ca_Map[i_Row, i_Col] = '0';
                }
            }

            for (int i_Ct = 0; i_Ct < 10; i_Ct++)
            {
                int i_Row = ia_MIndex[i_Ct] / 10;  //假設28/10=2
                int i_Col = ia_MIndex[i_Ct] % 10;  //28%10 =8

                if ((i_Row - 1) >= 0 && (i_Col - 1) >= 0)
                { //左上
                    int i = Convert.ToInt32(Ca_Map[i_Row - 1, i_Col - 1]);
                    i++;
                    (Ca_Map[i_Row - 1, i_Col - 1]) = Convert.ToChar(i);
                    Ca_Map[i_Row, i_Col] = '*';
                }

                if ((i_Row - 1) >= 0) //上
                {
                    int i = Convert.ToInt32(Ca_Map[i_Row - 1, i_Col]);
                    i++;
                    (Ca_Map[i_Row - 1, i_Col]) = Convert.ToChar(i);
                    Ca_Map[i_Row, i_Col] = '*';
                }

                if ((i_Row - 1) >= 0 && (i_Col + 1) <= 9) //右上
                {
                    int i = Convert.ToInt32(Ca_Map[i_Row - 1, i_Col + 1]);
                    i++;
                    (Ca_Map[i_Row - 1, i_Col + 1]) = Convert.ToChar(i);
                    Ca_Map[i_Row, i_Col] = '*';
                }
                if ((i_Col + 1) <= 9) //右
                {
                    int i = Convert.ToInt32(Ca_Map[i_Row, i_Col + 1]);
                    i++;
                    (Ca_Map[i_Row, i_Col + 1]) = Convert.ToChar(i);
                    Ca_Map[i_Row, i_Col] = '*';
                }

                if ((i_Row + 1) <= 9 && (i_Col - 1) >= 0) //左下
                {
                    int i = Convert.ToInt32(Ca_Map[i_Row + 1, i_Col - 1]);
                    i++;
                    (Ca_Map[i_Row + 1, i_Col - 1]) = Convert.ToChar(i);
                    Ca_Map[i_Row, i_Col] = '*';
                }

                if ((i_Row + 1) <= 9) //下
                {
                    int i = Convert.ToInt32(Ca_Map[i_Row + 1, i_Col]);
                    i++;
                    (Ca_Map[i_Row + 1, i_Col]) = Convert.ToChar(i);
                    Ca_Map[i_Row, i_Col] = '*';
                }

                if ((i_Row + 1) <= 9 && (i_Col + 1 <= 9)) //右下
                {
                    int i = Convert.ToInt32(Ca_Map[i_Row + 1, i_Col + 1]);
                    i++;
                    (Ca_Map[i_Row + 1, i_Col + 1]) = Convert.ToChar(i);
                    Ca_Map[i_Row, i_Col] = '*';
                }

                if ((i_Col - 1) >= 0) //左
                {
                    if (Ca_Map[i_Row, i_Col - 1] == '*') continue;
                    int i = Convert.ToInt32(Ca_Map[i_Row, i_Col - 1]);
                    i++;
                    (Ca_Map[i_Row, i_Col - 1]) = Convert.ToChar(i);
                    Ca_Map[i_Row, i_Col] = '*';
                }
            }

            for (int i_Row = 0; i_Row < 10; i_Row++)
            {
                for (int i_Col = 0; i_Col < 10; i_Col++)
                {
                    Response.Write(Ca_Map[i_Row, i_Col]);
                }
                Response.Write("<br>");
            }
        }
    }
}