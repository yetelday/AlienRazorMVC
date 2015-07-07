// File:    Equipement.cs
// Author:  Ghost_A
// Created: mardi 12 mai 2015 13:45:10
// Purpose: Definition of Class Equipement

using System;

namespace Bo
{
   public class Equipement
   {
      private int numSerieEquip;
      
      public System.Collections.Generic.List<FicheDepannage> ficheDepannage;
      
      /// <summary>
      /// Property for collection of FicheDepannage
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<FicheDepannage> FicheDepannage
      {
         get
         {
            if (ficheDepannage == null)
               ficheDepannage = new System.Collections.Generic.List<FicheDepannage>();
            return ficheDepannage;
         }
         set
         {
            RemoveAllFicheDepannage();
            if (value != null)
            {
               foreach (FicheDepannage oFicheDepannage in value)
                  AddFicheDepannage(oFicheDepannage);
            }
         }
      }
      
      /// <summary>
      /// Add a new FicheDepannage in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddFicheDepannage(FicheDepannage newFicheDepannage)
      {
         if (newFicheDepannage == null)
            return;
         if (this.ficheDepannage == null)
            this.ficheDepannage = new System.Collections.Generic.List<FicheDepannage>();
         if (!this.ficheDepannage.Contains(newFicheDepannage))
            this.ficheDepannage.Add(newFicheDepannage);
      }
      
      /// <summary>
      /// Remove an existing FicheDepannage from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveFicheDepannage(FicheDepannage oldFicheDepannage)
      {
         if (oldFicheDepannage == null)
            return;
         if (this.ficheDepannage != null)
            if (this.ficheDepannage.Contains(oldFicheDepannage))
               this.ficheDepannage.Remove(oldFicheDepannage);
      }
      
      /// <summary>
      /// Remove all instances of FicheDepannage from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllFicheDepannage()
      {
         if (ficheDepannage != null)
            ficheDepannage.Clear();
      }
   
   }
}