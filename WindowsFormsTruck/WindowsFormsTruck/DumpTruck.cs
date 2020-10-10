﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{
    //<summary>
    //Класс отрисовки спортивного автомобиля
    //</summary>
    class DumpTruck : Truck
    {
        //<summary>
        //Дополнительный цвет самосвала
        //</summary>
        public Color DopColor { private set; get; }

        //<summary>
        //Признак наличия прицепа
        //</summary>
        public bool Trailer { private set; get; }

        //<summary>
        //Признак наличия груза
        //</summary>
        public bool Cargo { private set; get; }

        //<summary>
        //Конструктор
        //</summary>
        public DumpTruck(int maxSpeed, float weight, Color mainColor, Color dopColor, bool trailer, bool cargo) : base(maxSpeed, weight, mainColor, 112, 42)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Trailer = trailer;
            Cargo = cargo;
        }

        /// <summary>
        /// Отрисовка грузовика
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush br = new SolidBrush(MainColor);
            Brush brDop = new SolidBrush(DopColor);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            Brush brWhite = new SolidBrush(Color.White);

            base.DrawTransport(g);

            //Груз
            if (Trailer)
            {
                Brush spoiler = new SolidBrush(DopColor);
                if (Cargo)
                {

                    g.FillRectangle(brGray, _startPosX + 10, _startPosY - 50, 34, 5);
                    g.FillRectangle(brGray, _startPosX + 7, _startPosY - 47, 41, 10);
                    g.FillRectangle(brGray, _startPosX + 1, _startPosY - 44, 70, 7);
                }
                g.FillRectangle(brDop, _startPosX - 2, _startPosY - 36, 74, 34);
                g.FillRectangle(brDop, _startPosX - 5, _startPosY - 38, 80, 30);
                g.FillRectangle(brDop, _startPosX + 55, _startPosY - 40, 30, 3);
            }
        }
    }
}
