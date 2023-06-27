using NetPortProxy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

/// <summary>
///  INI �ļ�����������
///  Ĭ�������ļ�·����bin/config.ini
///  Ĭ������SectionName��config,config2
/// </summary>
public static class INIHelper
{
    //private static string path = Application.streamingAssetsPath;
    public static string mINIFileName = "./config.ini";
    public static string mINIFileNameDefault = "./config.ini";

    public enum SectionName
    {
        config,//���
        config2,//�����ڴ�
        BlinkBox,//ä������
        Screen//��Ļ����
    }

    public static bool GetBool(string Key, SectionName section = SectionName.config, bool defaultValue = false)
    {
        bool value = defaultValue;
        string sectionName = section.ToString();

        Action<INIParser> action =
            (ini) =>
            {
                if (!ini.IsKeyExists(sectionName, Key))
                    ini.WriteValue(sectionName, Key, defaultValue);
                value = ini.ReadValue(sectionName, Key, defaultValue);
            };
        OpenAndReadINI(mINIFileName, action);

        return value;
    }


    public static string GetString(string Key, SectionName section = SectionName.config, string defaultValue = "")
    {
        string value = defaultValue;
        string sectionName = section.ToString();

        Action<INIParser> action =
            (ini) =>
            {
                if (!ini.IsKeyExists(sectionName, Key))
                    ini.WriteValue(sectionName, Key, defaultValue);
                value = ini.ReadValue(sectionName, Key, defaultValue);
            };

        OpenAndReadINI(mINIFileName, action);
        return value;
    }

    public static float GetFloat(string Key, SectionName section = SectionName.config, float defaultValue = 0)
    {
        float value = defaultValue;
        string sectionName = section.ToString();

        Action<INIParser> action =
            (ini) =>
            {
                if (!ini.IsKeyExists(sectionName, Key))
                    ini.WriteValue(sectionName, Key, defaultValue);
                value = (float)ini.ReadValue(sectionName, Key, defaultValue);
            };
        OpenAndReadINI(mINIFileName, action);
        return value;

    }

    public static void WriteString(string Key, SectionName section = SectionName.config, string defaultValue = "")
    {
        string sectionName = section.ToString();
        Action<INIParser> action =
            (ini) =>
            {
                ini.WriteValue(sectionName, Key, defaultValue);
            };
        OpenAndReadINI(mINIFileName, action);
    }

    public static void WriteBool(string Key, SectionName section = SectionName.config, bool defaultValue = false)
    {
        string sectionName = section.ToString();
        Action<INIParser> action =
            (ini) =>
            {
                ini.WriteValue(sectionName, Key, defaultValue);
            };
        OpenAndReadINI(mINIFileName, action);
    }
    public static void WriteFloat(string Key, SectionName section = SectionName.config, float defaultValue = 0)
    {
        string sectionName = section.ToString();
        Action<INIParser> action =
            (ini) =>
            {
                ini.WriteValue(sectionName, Key, defaultValue);
            };
        OpenAndReadINI(mINIFileName, action);
    }

    public static int GetInt(string Key, SectionName section = SectionName.config, int defaultValue = 0)
    {
        int value = defaultValue;
        string sectionName = section.ToString();

        Action<INIParser> action =
            (ini) =>
            {
                if (!ini.IsKeyExists(sectionName, Key))
                    ini.WriteValue(sectionName, Key, defaultValue);
                value = ini.ReadValue(sectionName, Key, defaultValue);
            };
        OpenAndReadINI(mINIFileName, action);

        return value;
    }

    static void OpenAndReadINI(string path, Action<INIParser> actionRead)
    {
        //Debug.Log("��ȡ����");
        try
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                Form1.ins.LogMsg("Create Success:" + path);
            }
            else
            {
                INIParser iniParser = new INIParser();
                iniParser.Open(path);

                actionRead(iniParser);

                iniParser.Close();
            }
        }
        catch (Exception e)
        {
            Form1.ins.LogMsg("INIFile Not Found Or Create:\r\n" + path + "\r\n" + e);
        }
    }
}