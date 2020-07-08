﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IBGECart.Interface
{
    public static class ConteudoCartinfTeste
    {
        private static readonly string CARTINF01 = "31062000503120A0938       04012490201020120201310620012319992999931062009992330814038087                        " + Environment.NewLine + "31062000503120A0938       04012500201020120201310620012319993199931578079993130814038095                        " + Environment.NewLine + "31062000503120A0938       04012510201020120201310620012319993199931186019993830814045784                        " + Environment.NewLine + "31062000503120A0938       04012520201020120201310620011319993199931062009993330814038036                        " + Environment.NewLine + "31062000503120A0938       04012530201020120201310620012319993199931062009992330814045849                         ";
        private static readonly string CARTINF02 = "31062000503120B0335       0085074030103012020121110011983110119933162104999311860199931062009993106200999" + Environment.NewLine + "31062000503120B0335       0085075030103012020121106111990081219834106902999310620099931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085170310131012020123101121981310119863106200999310740699931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085171310131012020123126091953041019543106200999313420299931062009993106200999" + Environment.NewLine + "31062000503120B0336       008517298999999999999999999999999999999                                        " + Environment.NewLine + "31062000503120B0336       008517398999999999999999999999999999999                                        " + Environment.NewLine + "31062000503120B0336       0085174040204022020121318111988141219953106200999312810599931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085175040204022020121120011988030419913106200999310620099931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085176040204022020122317091948080319623108602999316555299931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085187070207022020121124021984140819873106200999310620099931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085188070207022020121121071986130919933106200999312770199931062009993106200999" + Environment.NewLine + "31062000503120B0336       008518998999999999999999999999999999999                                        " + Environment.NewLine + "31062000503120B0336       0085190070207022020121113051998010119943106200999310620099931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085191070207022020123310121976020519843106200999310620099931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085283040304032020123121061985200319853106200999310620099931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085284040304032020121326111975140419849899999620310620099998999997563106200999" + Environment.NewLine + "31062000503120B0336       0085285040304032020121127091999221119993106200999310620099931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085286040304032020123125081978210219823113404999310620099931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085287040304032020121103031980100519883106200999310620099931062009993106200999" + Environment.NewLine + "31062000503120B0336       008528898999999999999999999999999999999                                        " + Environment.NewLine + "31062000503120B0336       0085289050305032020121115041991050419933106200999310620099931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085290050305032020121109121966071119813106200999311350399931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085291060306032020123101011975300619823106200999310620099931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085379200320032020121126031983180819883136702999310620099931062009993106200999" + Environment.NewLine + "31062000503120B0336       0085380200320032020121130091991301219913131307999310620099931313079993106200999" + Environment.NewLine + "31062000503120BAUXILIAR0400016515270114122019121129091992130119953139508999330100999931062009993106200999" + Environment.NewLine + "31062000503120BAUXILIAR040001651698999999999999999999999999999999                                        " + Environment.NewLine + "31062000503120BAUXILIAR040001651798999999999999999999999999999999                                        " + Environment.NewLine + "31062000503120BAUXILIAR040001651898999999999999999999999999999999                                        " + Environment.NewLine + "31062000503120BAUXILIAR040001651998999999999999999999999999999999                                        " + Environment.NewLine + "31062000503120BAUXILIAR0400016520180231012020121105071991290619973106200999310620099931062009993106200999" + Environment.NewLine;
        private static readonly string CARTINF03 = "31062000503120C0493       020368902010101202011319999999910834327999292996195                          " + Environment.NewLine + "31062000503120C0493       020369002010101202011319999999910514231999293003238                          " + Environment.NewLine + "31062000503120C0494       020389524012401202011310510399910824231999293021104                          " + Environment.NewLine + "31062000503120C0494       020389624012301202013310620099920374131999293040613                          " + Environment.NewLine + "31062000503120C0494       020389798999999999999          999999                                        " + Environment.NewLine + "31062000503120C0494       020389824012401202011319999999910534231999293021112                          " + Environment.NewLine + "31062000503120C0494       020389924012401202011314330299920804231999292996950                          " + Environment.NewLine + "31062000503120C0495       020407718021802202011319999999920964331999282207678                          " + Environment.NewLine + "31062000503120C0495       020407819021802202011310620099910584231999293072272                          " + Environment.NewLine + "31062000503120C0495       020407919021802202013310620099910184131999282314482                          " + Environment.NewLine + "31062000503120C0495       020408019021802202011319999999910604231999293044090                          " + Environment.NewLine + "31062000503120C0495       020408119021802202011310620099920904331999                                   " + Environment.NewLine + "31062000503120C0495       020408219021802202011319999999920684631999293019150                          " + Environment.NewLine + "31062000503120C0495       020408319021802202012310620099910554131999293019479                          " + Environment.NewLine + "31062000503120C0495       020408419021802202011310620099910484131999293035466                          " + Environment.NewLine + "31062000503120C0495       020422513031303202011319999999920924331999293094012                          " + Environment.NewLine + "31062000503120C0495       020422613032902202012319999999920944331999293080291                          " + Environment.NewLine + "31062000503120C0495       0204227130313032020133199999999110243319994635455                            " + Environment.NewLine + "31062000503120C0495       020422816031503202011310310399920774324999293044848                          " + Environment.NewLine + "31062000503120C0495       020422916031503202011319999999910954331999293045518                          " + Environment.NewLine + "31062000503120C0495       020423016031503202011319999999910724231999293073467                          " + Environment.NewLine + "31062000503120C0496       020434630032903202013319999999920754233999293100713                          " + Environment.NewLine + "31062000503120C0496       020434730033003202011319999999910884231999293098735                          " + Environment.NewLine + "31062000503120C0496       020434898999999999999          999999                                        " + Environment.NewLine + "31062000503120C0496       020434930033003202011310620099920484231999293105006                          " + Environment.NewLine + "31062000503120C0496       020435030033003202013319999999910924231999299276198                          " + Environment.NewLine + "31062000503120C0496       020435130032703202011310620099920324231999293089191                          " + Environment.NewLine + "31062000503120C0496       020436431033103202011319999999920764331999293105057                          " + Environment.NewLine + "31062000503120C0496       020436531033103202011310620099920774331999293105308                          " + Environment.NewLine + "31062000503120C0496       020436631033103202011316030699910674331999293093571                          " + Environment.NewLine + "31062000503120C0496       020436731033103202011319999999920724131999293105316                          " + Environment.NewLine;
        private static readonly string CARTINF04 = "31062000503120CAUXILIAR01300128810601131062002131999319993118601999273282281355                          " + Environment.NewLine + "31062000503120CAUXILIAR01300128820601131062001131999319993118601999274282281355                          " + Environment.NewLine + "31062000503120CAUXILIAR01300128830601131062002131999319993118601999273282281363                          " + Environment.NewLine + "31062000503120CAUXILIAR01300128840701131062001131999319993129806999295282281380                          " + Environment.NewLine + "31062000503120CAUXILIAR01300128851001131062001231999319993106200999212282273557                          " + Environment.NewLine + "31062000503120CAUXILIAR01300128861001131062001131999319993106200999304282281401                          " + Environment.NewLine + "31062000503120CAUXILIAR01300128871401131062001131999319993156700999373282281436                          " + Environment.NewLine + "31062000503120CAUXILIAR01300128881701131062001231999319993118601999292282273590                          " + Environment.NewLine + "31062000503120CAUXILIAR01300128892001131062001131999319993106200999341282281460                          " + Environment.NewLine + "31062000503120CAUXILIAR01300128902201131062001131999319993106200999221282281479                          " + Environment.NewLine + "31062000503120CAUXILIAR01400128913101131062001131999319993106200999351282281487                          " + Environment.NewLine + "31062000503120CAUXILIAR01400128920402131062001131999319993106200999262282273646                          " + Environment.NewLine + "31062000503120CAUXILIAR01400128930602131062001231999319993106200999131282273689                          " + Environment.NewLine + "31062000503120CAUXILIAR01400128941702131062001131999319993149309999243282281517                          " + Environment.NewLine + "31062000503120CAUXILIAR01400128950303131062001231999319993137601999272293032084                          " + Environment.NewLine + "31062000503120CAUXILIAR01400128960603131062001125999319993106200999259282273719                          " + Environment.NewLine + "31062000503120CAUXILIAR01400128971003131062001231999319993106200999333293032386                          " + Environment.NewLine + "31062000503120CAUXILIAR01400128981103131062001231999319993154606999272293032394                          " + Environment.NewLine + "31062000503120CAUXILIAR01400128991103131062001131999319993106200999332293032408                          " + Environment.NewLine + "31062000503120CAUXILIAR01400129001303131062001131999319993118601999313293089078                          " + Environment.NewLine + "31062000503120CAUXILIAR01400129011303131062001131999319993106200999292293089086                          " + Environment.NewLine + "31062000503120CAUXILIAR01400129021803131062001131999319993144805999322293089124                          " + Environment.NewLine + "31062000503120CAUXILIAR01400129031803131062001231999319993118601999252293089132                          " + Environment.NewLine;

        private static readonly string CARTINF01_NOME = "CARTINF01.TXT";
        private static readonly string CARTINF02_NOME = "CARTINF02.TXT";
        private static readonly string CARTINF03_NOME = "CARTINF03.TXT";
        private static readonly string CARTINF04_NOME = "CARTINF04.TXT";

        public static void CriarArquivo(TipoArquivo tipoArquivo)
        {
            string nome, conteudo;

            switch(tipoArquivo)
            {
                case TipoArquivo.Cartinf01:
                    nome = ConteudoCartinfTeste.CARTINF01_NOME;
                    conteudo = ConteudoCartinfTeste.CARTINF01;
                    break;

                case TipoArquivo.Cartinf02:
                    nome = ConteudoCartinfTeste.CARTINF02_NOME;
                    conteudo = ConteudoCartinfTeste.CARTINF02;
                    break;

                case TipoArquivo.Cartinf03:
                    nome = ConteudoCartinfTeste.CARTINF03_NOME;
                    conteudo = ConteudoCartinfTeste.CARTINF03;
                    break;

                case TipoArquivo.Cartinf04:
                    nome = ConteudoCartinfTeste.CARTINF04_NOME;
                    conteudo = ConteudoCartinfTeste.CARTINF04;
                    break;

                default:
                    throw new Exception("Não existe tipo passado.");

            }

            if (!File.Exists(nome))
            {
                File.WriteAllText(nome, conteudo);
            }
            else
            {
                Console.WriteLine("Arquivo " + nome + " já existe. Delete-o para criar um de teste.");
            }
        }
    }
}