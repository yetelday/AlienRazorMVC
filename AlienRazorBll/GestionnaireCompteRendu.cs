// File:    GestionnaireCompteRendu.cs
// Author:  cdi01
// Created: mercredi 1 juillet 2015 14:43:10
// Purpose: Definition of Class GestionnaireCompteRendu

using System;
using Bo;

namespace Creation_compte_rendu
{
   public class GestionnaireCompteRendu
   {
      public FicheDepannage GetInterById(int idInter)
      {
         throw new NotImplementedException();
      }
      
      public Array GetAllInterByIdTech(int idTech)
      {
         throw new NotImplementedException();
      }
      
      public void CreerCompteRendu(int idCompteRendu, Bo.Client client, DateTime date, DateTime duree, System.Array piecesUtilisees, string commentaire)
      {
         throw new NotImplementedException();
      }
      
      public ManagerCompteRendu mngCompteRendu;
      public GestionnaireInterventions gestionnaireInterventions;
   
   }
}