// File:    Magasinier.cs
// Author:  Ghost_A
// Created: mardi 12 mai 2015 09:54:50
// Purpose: Definition of Class Magasinier

using System;

namespace Bo
{
   public class Magasinier : Humain
   {
      private int idMagasinier;
      
      public System.Collections.Generic.List<BonCommande> bonCommande;
      
      /// <summary>
      /// Property for collection of BonCommande
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<BonCommande> BonCommande
      {
         get
         {
            if (bonCommande == null)
               bonCommande = new System.Collections.Generic.List<BonCommande>();
            return bonCommande;
         }
         set
         {
            RemoveAllBonCommande();
            if (value != null)
            {
               foreach (BonCommande oBonCommande in value)
                  AddBonCommande(oBonCommande);
            }
         }
      }
      
      /// <summary>
      /// Add a new BonCommande in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddBonCommande(BonCommande newBonCommande)
      {
         if (newBonCommande == null)
            return;
         if (this.bonCommande == null)
            this.bonCommande = new System.Collections.Generic.List<BonCommande>();
         if (!this.bonCommande.Contains(newBonCommande))
            this.bonCommande.Add(newBonCommande);
      }
      
      /// <summary>
      /// Remove an existing BonCommande from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveBonCommande(BonCommande oldBonCommande)
      {
         if (oldBonCommande == null)
            return;
         if (this.bonCommande != null)
            if (this.bonCommande.Contains(oldBonCommande))
               this.bonCommande.Remove(oldBonCommande);
      }
      
      /// <summary>
      /// Remove all instances of BonCommande from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllBonCommande()
      {
         if (bonCommande != null)
            bonCommande.Clear();
      }
      public System.Collections.Generic.List<BonSortie> bonSortie;
      
      /// <summary>
      /// Property for collection of BonSortie
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<BonSortie> BonSortie
      {
         get
         {
            if (bonSortie == null)
               bonSortie = new System.Collections.Generic.List<BonSortie>();
            return bonSortie;
         }
         set
         {
            RemoveAllBonSortie();
            if (value != null)
            {
               foreach (BonSortie oBonSortie in value)
                  AddBonSortie(oBonSortie);
            }
         }
      }
      
      /// <summary>
      /// Add a new BonSortie in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddBonSortie(BonSortie newBonSortie)
      {
         if (newBonSortie == null)
            return;
         if (this.bonSortie == null)
            this.bonSortie = new System.Collections.Generic.List<BonSortie>();
         if (!this.bonSortie.Contains(newBonSortie))
            this.bonSortie.Add(newBonSortie);
      }
      
      /// <summary>
      /// Remove an existing BonSortie from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveBonSortie(BonSortie oldBonSortie)
      {
         if (oldBonSortie == null)
            return;
         if (this.bonSortie != null)
            if (this.bonSortie.Contains(oldBonSortie))
               this.bonSortie.Remove(oldBonSortie);
      }
      
      /// <summary>
      /// Remove all instances of BonSortie from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllBonSortie()
      {
         if (bonSortie != null)
            bonSortie.Clear();
      }
   
   }
}