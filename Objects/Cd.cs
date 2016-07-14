using System;
using System.Collections.Generic;

namespace CdList.Objects
{
  public class Cd
  {
    private string _artist;
    private string _title;
    private int _id;
    private static List<Cd> _instances = new List<Cd>{};
    public static List<Cd> SearchCds = new List<Cd>{};

    public Cd(string artist, string title)
    {
      _artist = artist;
      _title = title;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetArtist()
    {
      return _artist;
    }
    public string GetTitle()
    {
      return _title;
    }
    public int GetId()
    {
      return _id;
    }
    public void SetArtist(string newArtist)
    {
      _artist = newArtist;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public static List<Cd> GetAll()
    {
      return _instances;
    }

    public static List<Cd> Find(string artists)
    {
      SearchCds.Clear();
      foreach( var everyCds in _instances)
      {
        if(everyCds.GetArtist()==artists)
        {
          SearchCds.Add(everyCds);
        }
      }
      return SearchCds;
    }

  }
}
