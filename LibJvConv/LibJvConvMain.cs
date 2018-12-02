﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibJvConv
{
    /**JVDataをコンバートするライブラリ
     * JV-Data 仕様書Excel版（Ver.4.5.1.3）準拠
     * 
     * */
    public class LibJvConvFuncClass
    {

        unsafe public static void jvSysConvFunction(int* msg, String inParam, String outParam)
        {

            if (msg == null || inParam == null)
            {
                return;
            }

            switch (*msg)
            {
                case 1:
                    JV_APP_CV_COURCE(ref inParam, ref outParam);
                    break;
                default:
                    break;
            }



        }

        /* 2001:競馬場コード */
        private static void JV_APP_CV_COURCE(ref String inParam, ref String outParam)
        {
            String tmp = "";
            switch (inParam)
            {
                case "00": tmp = " "; break;
                case "01": tmp = "札幌"; break;
                case "02": tmp = "函館"; break;
                case "03": tmp = "福島"; break;
                case "04": tmp = "新潟"; break;
                case "05": tmp = "東京"; break;
                case "06": tmp = "中山"; break;
                case "07": tmp = "中京"; break;
                case "08": tmp = "京都"; break;
                case "09": tmp = "阪神"; break;
                case "10": tmp = "小倉"; break;
                case "30": tmp = "門別"; break;
                case "31": tmp = "北見"; break;
                case "32": tmp = "岩見沢"; break;
                case "33": tmp = "帯広"; break;
                case "34": tmp = "旭川"; break;
                case "35": tmp = "盛岡"; break;
                case "36": tmp = "水沢"; break;
                case "37": tmp = "上山"; break;
                case "38": tmp = "三条"; break;
                case "39": tmp = "足利"; break;
                case "40": tmp = "宇都宮"; break;
                case "41": tmp = "高崎"; break;
                case "42": tmp = "浦和"; break;
                case "43": tmp = "船橋"; break;
                case "44": tmp = "大井"; break;
                case "45": tmp = "川崎"; break;
                case "46": tmp = "金沢"; break;
                case "47": tmp = "笠松"; break;
                case "48": tmp = "名古屋"; break;
                case "49": tmp = "紀三寺"; break;
                case "50": tmp = "園田"; break;
                case "51": tmp = "姫路"; break;
                case "52": tmp = "益田"; break;
                case "53": tmp = "福山"; break;
                case "54": tmp = "高知"; break;
                case "55": tmp = "佐賀"; break;
                case "56": tmp = "荒尾"; break;
                case "57": tmp = "中津"; break;
                case "58": tmp = "札幌"; break;
                case "59": tmp = "函館"; break;
                case "60": tmp = "新潟"; break;
                case "61": tmp = "中京"; break;
                case "A0": tmp = "他外国"; break;
                case "A2": tmp = "日本"; break;
                case "A4": tmp = "アメリ"; break;
                case "A6": tmp = "イギリ"; break;
                case "A8": tmp = "フラン"; break;
                case "B0": tmp = "インド"; break;
                case "B2": tmp = "アイル"; break;
                case "B4": tmp = "ニュー"; break;
                case "B6": tmp = "オース"; break;
                case "B8": tmp = "カナダ"; break;
                case "C0": tmp = "イタリ"; break;
                case "C2": tmp = "ドイツ"; break;
                case "C5": tmp = "オマー"; break;
                case "C6": tmp = "イラク"; break;
                case "C7": tmp = "アラブ"; break;
                case "C8": tmp = "シリア"; break;
                case "D0": tmp = "スウェ"; break;
                case "D2": tmp = "ハンガ"; break;
                case "D4": tmp = "ポルト"; break;
                case "D6": tmp = "ロシア"; break;
                case "D8": tmp = "ウルグ"; break;
                case "E0": tmp = "ペルー"; break;
                case "E2": tmp = "アルゼ"; break;
                case "E4": tmp = "ブラジ"; break;
                case "E6": tmp = "ベルギ"; break;
                case "E8": tmp = "トルコ"; break;
                case "F0": tmp = "韓国"; break;
                case "F1": tmp = "中国"; break;
                case "F2": tmp = "チリ"; break;
                case "F8": tmp = "パナマ"; break;
                case "G0": tmp = "香港"; break;
                case "G2": tmp = "スペイ"; break;
                case "H0": tmp = "西独"; break;
                case "H2": tmp = "南アフ"; break;
                case "H4": tmp = "スイス"; break;
                case "H6": tmp = "モナコ"; break;
                case "H8": tmp = "フィリ"; break;
                case "I0": tmp = "プエル"; break;
                case "I2": tmp = "コロン"; break;
                case "I4": tmp = "チェコ"; break;
                case "I6": tmp = "チェコ"; break;
                case "I8": tmp = "スロバ"; break;
                case "J0": tmp = "エクア"; break;
                case "J2": tmp = "ギリシ"; break;
                case "J4": tmp = "マレー"; break;
                case "J6": tmp = "メキシ"; break;
                case "J8": tmp = "モロッ"; break;
                case "K0": tmp = "パキス"; break;
                case "K2": tmp = "ポーラ"; break;
                case "K4": tmp = "パラグ"; break;
                case "K6": tmp = "サウジ"; break;
                case "K8": tmp = "キプロ"; break;
                case "L0": tmp = "タイ"; break;
                case "L2": tmp = "ウクラ"; break;
                case "L4": tmp = "ベネゼ"; break;
                case "L6": tmp = "ユーゴ"; break;
                case "L8": tmp = "デンマ"; break;
                case "M0": tmp = "シンガ"; break;
                case "M2": tmp = "マカオ"; break;
                case "M4": tmp = "墺国"; break;
                case "M6": tmp = "ヨルダ"; break;
                case "M8": tmp = "カタル"; break;
            }

            outParam = tmp;
        }

        /* 2002:曜日コード */
        private static void JV_APP_CV_WEEKDAY(ref String inParam, ref String outParam)
        {
            String tmp;
            switch (inParam)
            {
                case "00": tmp = " "; break;
                case "1": tmp = "土"; break;
                case "2": tmp = "日"; break;
                case "3": tmp = "祝"; break;
                case "4": tmp = "月"; break;
                case "5": tmp = "火"; break;
                case "6": tmp = "水"; break;
                case "7": tmp = "木"; break;
                case "8": tmp = "金"; break;
                default: tmp = "";    break;
            }
            outParam = tmp;
        }

        /* 20031:グレードコード（長） */
        private static void JV_APP_CV_GRADE_LONG(ref String inParam, ref String outParam)
        {
            String tmp;
            switch (inParam)
            {
                case "A": tmp = "ＧⅠ"; break;
                case "B": tmp = "ＧⅡ"; break;
                case "C": tmp = "ＧⅢ"; break;
                case "D": tmp = "重賞"; break;
                case "E": tmp = "特別"; break;
                case "F": tmp = "Ｊ・ＧⅠ"; break;
                case "G": tmp = "Ｊ・ＧⅡ"; break;
                case "H": tmp = "Ｊ・ＧⅢ"; break;
                case " ": tmp = "一般"; break;
                default: tmp = ""; break;
            }
            outParam = tmp;
        }

        /* 20032:グレードコード（短） */
        private static void JV_APP_CV_GRADE_SHORT(ref String inParam, ref String outParam)
        {
            String tmp;
            switch (inParam)
            {
                case "A": tmp = "G1"; break;
                case "B": tmp = "G2"; break;
                case "C": tmp = "G3"; break;
                case "D": tmp = "重賞"; break;
                case "E": tmp = "特別"; break;
                case "F": tmp = "JG1"; break;
                case "G": tmp = "JG2"; break;
                case "H": tmp = "JG3"; break;
                case " ": tmp = "一般"; break;
                default: tmp = ""; break;
            }
            outParam = tmp;
        }

        /* 2005:競走種別コード */
        private static void JV_APP_CV_RACE_SHUBETSU(ref String inParam, ref String outParam)
        {
            String tmp;
            switch (inParam)
            {
                case "00": tmp = " "; break;
                case "11": tmp = "サラ系２歳"; break;
                case "12": tmp = "サラ系３歳"; break;
                case "13": tmp = "サラ系３歳以上"; break;
                case "14": tmp = "サラ系４歳以上"; break;
                case "18": tmp = "サラ障害３歳以上"; break;
                case "19": tmp = "サラ障害４歳以上"; break;
                case "21": tmp = "アラブ系２歳"; break;
                case "22": tmp = "アラブ系３歳"; break;
                case "23": tmp = "アラブ系３歳以上"; break;
                case "24": tmp = "アラブ系４歳以上"; break;
                default: tmp = ""; break;
            }
            outParam = tmp;
        }

        /* 2006:競走記号コード */
        private static void JV_APP_CV_RACE_KIGOU(ref String inParam, ref String outParam)
        {
            String tmp,tmp2,tmp3;

            /* 1バイト目：産地・購買条件等 */
            switch(inParam.Substring(0,1))
            {
                case "0": tmp = "下記以外"; break;
                case "A": tmp = "(混合)"; break;
                case "B": tmp = "(父)"; break;
                case "C": tmp = "(市)"; break;
                case "D": tmp = "(抽)"; break;
                case "E": tmp = "[抽]"; break;
                case "F": tmp = "(市)(抽)"; break;
                case "G": tmp = "(抽)関西配布馬"; break;
                case "H": tmp = "(抽)関東配布馬"; break;
                case "I": tmp = "[抽]関西配布馬"; break;
                case "J": tmp = "[抽]関東配布馬"; break;
                case "K": tmp = "(市)(抽)関西配布馬"; break;
                case "L": tmp = "(市)(抽)関東配布馬"; break;
                case "M": tmp = "九州産馬"; break;
                case "N": tmp = "(国際)"; break;
                default: tmp = ""; break;
            }

            /* 2バイト目：産地・購買条件等 */
            switch (inParam.Substring(2, 1))
            {
                case "0":	tmp2 = ""; break;
                case "1":	tmp2 = "牡"; break;
                case "2":	tmp2 = "牝"; break;
                case "3":	tmp2 = "牡・ｾﾝ"; break;
                case "4":	tmp2 = "牡・牝"; break;
                default: tmp2 = ""; break;
            }

            /* 3バイト目：交流競走関係等 */
            switch (inParam.Substring(3, 1))
            {
                case "0": tmp3 = ""; break;
                case "1": tmp3 = "(指定)"; break;
                case "2": tmp3 = "見習騎手"; break;
                case "3": tmp3 = "[指定]"; break;
                case "4": tmp3 = "(特指)"; break;
                default: tmp3 = ""; break;
            }

            /* 文字列結合 */
            outParam = string.Join(tmp,tmp2,tmp3);
        }



    }
}