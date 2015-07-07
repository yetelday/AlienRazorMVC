// File:    Contrat.cs
// Author:  Ghost_A
// Created: mardi 12 mai 2015 09:56:52
// Purpose: Definition of Class Contrat

using System;

namespace Bo
{
   public class Contrat
   {
      private int idContrat;
      private DateTime datePriseEffet;
      private DateTime dateRelance;
      private DateTime dateResiliation;
      
      public System.Collections.Generic.List<Equipement> equipement;
      
      /// <summary>
      /// Property for collection of Equipement
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Equipement> Equipement
      {
         get
         {
            if (equipement == null)
               equipement = new System.Collections.Generic.List<Equipement>();
            return equipement;
         }
         set
         {
            RemoveAllEquipement();
            if (value != null)
            {
               foreach (Equipement oEquipement in value)
                  AddEquipement(oEquipement);
            }
         }
      }
      
      /// <summary>
      /// Add a new Equipement in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddEquipement(Equipement newEquipement)
      {
         if (newEquipement == null)
            return;
         if (this.equipement == null)
            this.equipement = new System.Collections.Generic.List<Equipement>();
         if (!this.equipement.Contains(newEquipement))
            this.equipement.Add(newEquipement);
      }
      
      /// <summary>
      /// Remove an existing Equipement from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveEquipement(Equipement oldEquipement)
      {
         if (oldEquipement == null)
            return;
         if (this.equipement != null)
            if (this.equipement.Contains(oldEquipement))
               this.equipement.Remove(oldEquipement);
      }
      
      /// <summary>
      /// Remove all instances of Equipement from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllEquipement()
      {
         if (equipement != null)
            equipement.Clear();
      }
      public Periodicite periodicite;
      
      /// <summary>
      /// Property for Periodicite
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Periodicite Periodicite
      {
         get
         {
            return periodicite;
         }
         set
         {
            this.periodicite = value;
         }
      }
   
   }
}