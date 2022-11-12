﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrowtopiaAutoclaveCalculator
{
    public partial class Form1 : Form
    {
        private float sponge = 0;
        private float scalpel = 0;
        private float stitches = 0;
        private float antibiotics = 0;
        private float splint = 0;
        private float antiseptic = 0;
        private float anesthetic = 0;
        private float labkit = 0;
        private float clamp = 0;
        private float pins = 0;
        private float transfusion = 0;
        private float ultrasound = 0;
        private float defib = 0;

        private float spongePrice = 14;
        private float scalpelPrice = 14;
        private float stitchesPrice = 1.538461538461538f;
        private float antibioticsPrice = 14;
        private float splintPrice = 0;
        private float antisepticPrice = 0;
        private float anestheticPrice = 0;
        private float labkitPrice = 0;
        private float clampPrice = 0;
        private float pinsPrice = 0;
        private float transfusionPrice = 0;
        private float ultrasoundPrice = 0;
        private float defibPrice = 0;

        private void ScalpelBox_TextChanged(object sender, EventArgs e)
        {
            scalpel = textCheck(ScalpelBox);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void autoclaved()
        {
            sponge += 1;
            scalpel += 1;
            stitches += 1;
            antibiotics += 1;
            splint += 1;
            antiseptic += 1;
            anesthetic += 1;
            labkit += 1;
            clamp += 1;
            pins += 1;
            transfusion += 1;
            ultrasound += 1;
            defib += 1;

            SpongeBox.Text = sponge.ToString();
            ScalpelBox.Text = scalpel.ToString();
            StitchesBox.Text = stitches.ToString();
            AntibioticsBox.Text = antibiotics.ToString();
            SplintBox.Text = splint.ToString();
            AntisepticBox.Text = antiseptic.ToString();
            AnestheticBox.Text = anesthetic.ToString();
            LabKitBox.Text = labkit.ToString();
            ClampBox.Text = clamp.ToString();
            PinsBox.Text = pins.ToString();
            TransfusionBox.Text = transfusion.ToString();
            UltrasoundBox.Text = ultrasound.ToString();
            DefibBox.Text = defib.ToString();
        }

        private void CalculateWLs(object sender, EventArgs e)
        {
            int a = 0;
            do
            {
                a = 0;
                if (checkBox1.Checked == true)
                {
                    if (sponge >= 20)
                    {
                        sponge -= 20;
                        autoclaved();
                    }
                    else
                    {
                        a += 1;
                    }
                }
                else
                {
                    a += 1;
                }
                if (checkBox2.Checked == true)
                {
                    if (scalpel >= 20)
                    {
                        scalpel -= 20;
                        autoclaved();
                    }
                    else
                    {
                        a += 1;
                    }
                }
                else
                {
                    a += 1;
                }
                if (checkBox3.Checked == true)
                {
                    if (stitches >= 20)
                    {
                        stitches -= 20;
                        autoclaved();
                    }
                    else
                    {
                        a += 1;
                    }
                }
                else
                {
                    a += 1;
                }
                if (checkBox4.Checked == true)
                {
                    if (antibiotics >= 20)
                    {
                        antibiotics -= 20;
                        autoclaved();
                    }
                    else
                    {
                        a += 1;
                    }
                }
                else
                {
                    a += 1;
                }
                if (checkBox5.Checked == true)
                {
                    if (splint >= 20)
                    {
                        splint -= 20;
                        autoclaved();
                    }
                    else
                    {
                        a += 1;
                    }
                }
                else
                {
                    a += 1;
                }
                if (checkBox6.Checked == true)
                {
                    if (antiseptic >= 20)
                    {
                        antiseptic -= 20;
                        autoclaved();
                    }
                    else
                    {
                        a += 1;
                    }
                }
                else
                {
                    a += 1;
                }
                if (checkBox7.Checked == true)
                {
                    if (anesthetic >= 20)
                    {
                        anesthetic -= 20;
                        autoclaved();
                    }
                    else
                    {
                        a += 1;
                    }
                }
                else
                {
                    a += 1;
                }
                if (checkBox8.Checked == true)
                {
                    if (labkit >= 20)
                    {
                        labkit -= 20;
                        autoclaved();
                    }
                    else
                    {
                        a += 1;
                    }
                }
                else
                {
                    a += 1;
                }
                if (checkBox9.Checked == true)
                {
                    if (clamp >= 20)
                    {
                        clamp -= 20;
                        autoclaved();
                    }
                    else
                    {
                        a += 1;
                    }
                }
                else
                {
                    a += 1;
                }
                if (checkBox10.Checked == true)
                {
                    if (pins >= 20)
                    {
                        pins -= 20;
                        autoclaved();
                    }
                    else
                    {
                        a += 1;
                    }
                }
                else
                {
                    a += 1;
                }
                if (checkBox11.Checked == true)
                {
                    if (transfusion >= 20)
                    {
                        transfusion -= 20;
                        autoclaved();
                    }
                    else
                    {
                        a += 1;
                    }
                }
                else
                {
                    a += 1;
                }
                if (checkBox12.Checked == true)
                {
                    if (ultrasound >= 20)
                    {
                        ultrasound -= 20;
                        autoclaved();
                    }
                    else
                    {
                        a += 1;
                    }
                }
                else
                {
                    a += 1;
                }
                if (checkBox13.Checked == true)
                {
                    if (defib >= 20)
                    {
                        defib -= 20;
                        autoclaved();
                    }
                    else
                    {
                        a += 1;
                    }
                }
                else
                {
                    a += 1;
                }
            } while (a < 13);
            float wlsearned = 0;
            if(spongePrice > 0) { wlsearned += (sponge / spongePrice); }
            if (scalpelPrice > 0) { wlsearned += (scalpel / scalpelPrice); }
            if (stitchesPrice > 0) { wlsearned += (stitches / stitchesPrice); }
            if (antibioticsPrice > 0) { wlsearned += (antibiotics / antibioticsPrice); }
            if (splintPrice > 0) { wlsearned += (splint / splintPrice); }
            if (antisepticPrice > 0) { wlsearned += (antiseptic / antisepticPrice); }
            if (anestheticPrice > 0) { wlsearned += (anesthetic / anestheticPrice); }
            if (labkitPrice > 0) { wlsearned += (labkit / labkitPrice); }
            if (clampPrice > 0) { wlsearned += (clamp / clampPrice); }
            if (pinsPrice > 0) { wlsearned += (pins / pinsPrice); }
            if (transfusionPrice > 0) { wlsearned += (transfusion / transfusionPrice); }
            if (ultrasoundPrice > 0) { wlsearned += (ultrasound / ultrasoundPrice); }
            if (defibPrice > 0) { wlsearned += (defib / defibPrice); }
            WLEarned.Text = Math.Floor(wlsearned).ToString();
        }

        private float textCheck(TextBox textBox)
        {
            string TBtext = textBox.Text;
            var isNumber = float.TryParse(TBtext, out float n);
            textBox.Text = n.ToString();
            return n;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StitchesBox_TextChanged(object sender, EventArgs e)
        {
            stitches = textCheck(StitchesBox);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sponge = textCheck(SpongeBox);
        }

        private void AntibioticsBox_TextChanged(object sender, EventArgs e)
        {
            antibiotics = textCheck(AntibioticsBox);
        }

        private void SplintBox_TextChanged(object sender, EventArgs e)
        {
            splint = textCheck(SplintBox);
        }

        private void AntisepticBox_TextChanged(object sender, EventArgs e)
        {
            antiseptic = textCheck(AntisepticBox);
        }

        private void AnestheticBox_TextChanged(object sender, EventArgs e)
        {
            anesthetic = textCheck(AnestheticBox);
        }

        private void LabKitBox_TextChanged(object sender, EventArgs e)
        {
            labkit = textCheck(LabKitBox);
        }

        private void ClampBox_TextChanged(object sender, EventArgs e)
        {
            clamp = textCheck(ClampBox);
        }

        private void PinsBox_TextChanged(object sender, EventArgs e)
        {
            pins = textCheck(PinsBox);
        }

        private void TransfusionBox_TextChanged(object sender, EventArgs e)
        {
            transfusion = textCheck(TransfusionBox);
        }

        private void UltrasoundBox_TextChanged(object sender, EventArgs e)
        {
            ultrasound = textCheck(UltrasoundBox);
        }

        private void DefibBox_TextChanged(object sender, EventArgs e)
        {
            defib = textCheck(DefibBox);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            spongePrice = textCheck(textBox13);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            scalpelPrice = textCheck(textBox12);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            stitchesPrice = textCheck(textBox11);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            antibioticsPrice = textCheck(textBox10);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            splintPrice = textCheck(textBox9);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            antisepticPrice = textCheck(textBox8);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            anestheticPrice = textCheck(textBox7);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            labkitPrice = textCheck(textBox6);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            clampPrice = textCheck(textBox5);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            pinsPrice = textCheck(textBox4);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            transfusionPrice = textCheck(textBox3);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ultrasoundPrice = textCheck(textBox2);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            defibPrice = textCheck(textBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpongeBox.Text = "0";
            ScalpelBox.Text = "0";
            StitchesBox.Text = "0";
            AntibioticsBox.Text = "0";
            SplintBox.Text = "0";
            AntisepticBox.Text = "0";
            AnestheticBox.Text = "0";
            LabKitBox.Text = "0";
            ClampBox.Text = "0";
            PinsBox.Text = "0";
            TransfusionBox.Text = "0";
            UltrasoundBox.Text = "0";
            DefibBox.Text = "0";
            WLEarned.Text = "0";
            sponge = 0;
            scalpel = 0;
            stitches = 0;
            antibiotics = 0;
            splint = 0;
            antiseptic = 0;
            anesthetic = 0;
            labkit = 0;
            clamp = 0;
            pins = 0;
            transfusion = 0;
            ultrasound = 0;
            defib = 0;
        }
    }
}
