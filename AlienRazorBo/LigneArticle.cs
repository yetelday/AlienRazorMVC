// File:    LigneArticle.cs
// Author:  Ghost_A
// Created: mardi 12 mai 2015 09:59:57
// Purpose: Definition of Class LigneArticle

using System;

namespace Bo
{
   public class LigneArticle
   {
      private int idLigneArticle;
      private int quantite;
      
      public System.Collections.Generic.List<CompteRenduDepannage> compteRenduDepannage;
      
      /// <summary>
      /// Property for collection of CompteRenduDepannage
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<CompteRenduDepannage> CompteRenduDepannage
      {
         get
         {
            if (compteRenduDepannage == null)
               compteRenduDepannage = new System.Collections.Generic.List<CompteRenduDepannage>();
            return compteRenduDepannage;
         }
         set
         {
            RemoveAllCompteRenduDepannage();
            if (value != null)
            {
               foreach (CompteRenduDepannage oCompteRenduDepannage in value)
                  AddCompteRenduDepannage(oCompteRenduDepannage);
            }
         }
      }
      
      /// <summary>
      /// Add a new CompteRenduDepannage in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddCompteRenduDepannage(CompteRenduDepannage newCompteRenduDepannage)
      {
         if (newCompteRenduDepannage == null)
            return;
         if (this.compteRenduDepannage == null)
            this.compteRenduDepannage = new System.Collections.Generic.List<CompteRenduDepannage>();
         if (!this.compteRenduDepannage.Contains(newCompteRenduDepannage))
            this.compteRenduDepannage.Add(newCompteRenduDepannage);
      }
      
      /// <summary>
      /// Remove an existing CompteRenduDepannage from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveCompteRenduDepannage(CompteRenduDepannage oldCompteRenduDepannage)
      {
         if (oldCompteRenduDepannage == null)
            return;
         if (this.compteRenduDepannage != null)
            if (this.compteRenduDepannage.Contains(oldCompteRenduDepannage))
               this.compteRenduDepannage.Remove(oldCompteRenduDepannage);
      }
      
      /// <summary>
      /// Remove all instances of CompteRenduDepannage from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllCompteRenduDepannage()
      {
         if (compteRenduDepannage != null)
            compteRenduDepannage.Clear();
      }
   
   }
}