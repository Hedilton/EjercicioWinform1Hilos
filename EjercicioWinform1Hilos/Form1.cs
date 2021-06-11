using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioWinform1Hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread a = new Thread(new ThreadStart(metodo1));
            Thread b = new Thread(new ThreadStart(metodo2));
            Thread c = new Thread(new ThreadStart(metodo3));
            a.Start();b.Start();c.Start();

        }
        private delegate void SetValueDelegate(int bpvalue);//definimos el delegado
        private delegate void SetValueDelegate1(Boolean bpvalue);//definimos el delegado
        private void SetValue_bpProgreso(int hecho)///definir metodo que permita asignar el valor de bpProgreso
        {
            if (bpProgreso.InvokeRequired) ///Si el identificador del control aún no existe, InvokeRequired busca en la cadena principal del control hasta que 
               // encuentra un control o formulario que sí tiene un identificador de ventana.
            {
                SetValueDelegate delegado = new SetValueDelegate(SetValue_bpProgreso);//se realiza llamada asincrona
                bpProgreso.Invoke(delegado, new object[] { hecho });//devuelve verdadero si el hilo que se invoca al metodo que se ejecuta, no corresponde con el hilo que se creo del control
            }
            else
            {
                bpProgreso.Value = hecho;
            }
        }
        private void metodo1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(15);
                SetValue_bpProgreso(i);
            }
            SetValue_che1(true);
        }
        private void SetValue_che1(Boolean hecho)///definir metodo que permita asignar el valor de bpProgreso
        {
            if (che1.InvokeRequired) ///Si el identificador del control aún no existe, InvokeRequired busca en la cadena principal del control hasta que 
               // encuentra un control o formulario que sí tiene un identificador de ventana.
            {
                SetValueDelegate1 delegado = new SetValueDelegate1(SetValue_che1);//se realiza llamada asincrona
                che1.Invoke(delegado, new object[] { hecho });//devuelve verdadero si el hilo que se invoca al metodo que se ejecuta, no corresponde con el hilo que se creo del control
            }
            else
            {
                che1.Checked = hecho;
            }
        }


        private void SetValue_bpProgreso1(int hecho)///definir metodo que permita asignar el valor de bpProgreso
        {
            if (bpProgreso1.InvokeRequired) ///Si el identificador del control aún no existe, InvokeRequired busca en la cadena principal del control hasta que 
               // encuentra un control o formulario que sí tiene un identificador de ventana.
            {
                SetValueDelegate delegado = new SetValueDelegate(SetValue_bpProgreso1);//se realiza llamada asincrona
                bpProgreso1.Invoke(delegado, new object[] { hecho });//devuelve verdadero si el hilo que se invoca al metodo que se ejecuta, no corresponde con el hilo que se creo del control
            }
            else
            {
                bpProgreso1.Value = hecho;
            }
        }
        private void metodo2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(18);
                SetValue_bpProgreso1(i);
            }
            SetValue_che2(true);
        }
        private void SetValue_bpProgreso2(int hecho)///definir metodo que permita asignar el valor de bpProgreso
        {
            if (bpProgreso1.InvokeRequired) ///Si el identificador del control aún no existe, InvokeRequired busca en la cadena principal del control hasta que 
               // encuentra un control o formulario que sí tiene un identificador de ventana.
            {
                SetValueDelegate delegado = new SetValueDelegate(SetValue_bpProgreso2);//se realiza llamada asincrona
                bpProgreso2.Invoke(delegado, new object[] { hecho });//devuelve verdadero si el hilo que se invoca al metodo que se ejecuta, no corresponde con el hilo que se creo del control
            }
            else
            {
                bpProgreso2.Value = hecho;
            }
        }
        private void metodo3()
        {
            for(int i=1;i<=100;i++)
            {
                Thread.Sleep(11);
                SetValue_bpProgreso2(i);
            }
            SetValue_che3(true);
        }

        private void SetValue_che2(Boolean hecho)///definir metodo que permita asignar el valor de bpProgreso
        {
            if (che1.InvokeRequired) ///Si el identificador del control aún no existe, InvokeRequired busca en la cadena principal del control hasta que 
               // encuentra un control o formulario que sí tiene un identificador de ventana.
            {
                SetValueDelegate1 delegado = new SetValueDelegate1(SetValue_che2);//se realiza llamada asincrona
                che2.Invoke(delegado, new object[] { hecho });//devuelve verdadero si el hilo que se invoca al metodo que se ejecuta, no corresponde con el hilo que se creo del control
            }
            else
            {
                che2.Checked = hecho;
            }
        }


        private void SetValue_che3(Boolean hecho)///definir metodo que permita asignar el valor de bpProgreso
        {
            if (che3.InvokeRequired) ///Si el identificador del control aún no existe, InvokeRequired busca en la cadena principal del control hasta que 
               // encuentra un control o formulario que sí tiene un identificador de ventana.
            {
                SetValueDelegate1 delegado = new SetValueDelegate1(SetValue_che3);//se realiza llamada asincrona
                che3.Invoke(delegado, new object[] { hecho });//devuelve verdadero si el hilo que se invoca al metodo que se ejecuta, no corresponde con el hilo que se creo del control
            }
            else
            {
                che3.Checked = hecho;
            }
        }
    }
}
