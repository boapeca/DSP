using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class DeploymentText : MonoBehaviour
{
    public static string Firewall;
    public static string CCTV;
    public static string Antivirus;
    public static string SecurityTraining;
    public static string NetworkMon;
    public static string AssetAudit;
    public static string PCUpgrade;
    public static string ServerUpgrade;
    public static string ControllerUpgrade;
    public static string PCEncryption;
    public static string DatabaseEncryption;


    private void Awake()
    {
        Firewall = "An engineer from a famous networking company comes to the office with a big box.They spend a day with the network administrator installing the firewall, configuring access rules and making sure that everything runs smoothly.";
        CCTV = "Cameras are installed at strategic points all around the plant: entrance, control room, turbine room, etc.Everything is linked to a central monitoring console where security guards monitor the offices 24 / 7.";
        Antivirus = "Two engineers come to both sites and spend a day installing the antivirus on all PCs, configuring it and making sure all employees understand its purpose and react properly in case of an alert.";
        SecurityTraining = "A team of professional trainers organise a one - day seminar for all employees and teach them essential security hygiene: Do not click on random links while browsing the Web. Do not open email attachments from unknown sources. Do not bring personal thumb drives to work, especially when you do not know where they come from! Here is how to design a secure, easy to remember password. And do not put it on a sticky note on your monitor! Etc.";
        NetworkMon = "The office/plant network administrator is extremely excited: they have got a brand new shiny toy to play with! The vendor sends one of their engineers to help with the installation, and the network administrator spends a few more days fine - tuning precise filtering rules and alert conditions. Soon, nothing that happens on the office network can escape their vigilance.";
        AssetAudit = "A team of external experts comes and spends an entire day on each site, scanning your networks and asking questions to your system administrators.They come back with a number of findings:  -- An unsecured, undocumented Wi-Fi network was found in the plant. After some investigation, this was set up years ago by an engineer, who is now retired. They needed to install a set of additional debit sensors on the water stream, and an open Wi - Fi network was a cheap and simple solution compared to deploying a complicated set of cables.The Wi-Fi network was never documented and eventually forgotten.It has now been secured with a strong password.  -- The company PCs run an old, insecure operating system long past its end of life. They can be upgraded to a recent, secure, supported operating system via the PC Upgrade.The server’s and database’s operating systems and software are also outdated and suffer from known vulnerabilities.These can be patched via a Server Upgrade. -- The controller’s firmware has never been updated since its deployment, twenty years ago.It is vulnerable to very simple exploits. A Controller Upgrade will patch known vulnerabilities. -- The company has never encrypted any data – everything is stored in the clear. PC Encryption will encrypt the content of all Personal Computers(e.g., technical documentation used by engineers). Database Encryption will encrypt the content of the two databases(controller monitoring data on the plant’s historian database, email, HR records, client contracts and other sensitive data on the office database).";
        PCUpgrade = "The week after the update is difficult: users complain that they are lost, they do not recognise the icons, they prefer the old system, and so on. After a few days, however, everyone gets used to the new environment, and soon enough the old PCs are no more than a fond memory.";
        ServerUpgrade = "The webmaster and system administrators take down the server and databases for a day, in order to deploy the new software, port the existing data and applications, and restart everything. Soon enough, everything is back up and running.";
        ControllerUpgrade = "Updating the controller takes three full days: one day to stop the whole process, one day to install the new firmware, and one day to restart everything and do all mandatory safety check.The cost of this defence also covers the business losses due to the three days downtime."; 
        PCEncryption = "The system administrators take a few days to review all PCs in use in the company and equip them with an up - to - date encryption suite. All data stored on Personal Computers is now encrypted with a strong cypher which makes it unreadable to whoever does not have the corresponding decryption key." ;
        DatabaseEncryption = "The database administrators take the office database and the plant’s historian down for a few hours. When they are restarted, all their content is now encrypted with a strong cypher which makes it unreadable to whoever does not have the corresponding decryption key." ;
    }



}
