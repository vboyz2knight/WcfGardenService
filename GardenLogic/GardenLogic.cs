using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GardenEntities;
using GardenDAL;

/* control any business logic in this project */

namespace GardenLogics
{
    public class GardenLogic
    {
        public bool AddPlant(GardenEntity newPlant)
        {
            throw new NotImplementedException();
        }

        public bool RemovePlant(GardenEntity removePlant)
        {
            throw new NotImplementedException();
        }

        public List<GardenEntity> ViewAllPlantsInGarden()
        {
            GardenDAO gardenDAO = new GardenDAO();
            List<GardenEntity> gardenEntityList = new List<GardenEntity>();
            if (gardenDAO !=null)
            {
                gardenEntityList = gardenDAO.ViewAllPlantsInGarden();
            }
            else
            {
                throw new Exception("GardenDAO is null. ViewAllPlantsInGarden");
            }
            return gardenEntityList;
        }

        public List<GardenEntity> ListAnnual()
        {
            GardenDAO gardenDAO = new GardenDAO();
            List<GardenEntity> gardenEntityList = new List<GardenEntity>();
            if (gardenDAO != null)
            {
                gardenEntityList = gardenDAO.ListAnnual();
            }
            else
            {
                throw new Exception("GardenDAO is null. ListAnnual");
            }
            return gardenEntityList;
        }

        public List<GardenEntity> ListPerenial()
        {
            GardenDAO gardenDAO = new GardenDAO();
            List<GardenEntity> gardenEntityList = new List<GardenEntity>();
            if (gardenDAO != null)
            {
                gardenEntityList = gardenDAO.ListPerenial();
            }
            else
            {
                throw new Exception("GardenDAO is null. ListPerenial");
            }
            return gardenEntityList;
        }

        public List<GardenEntity> ListPlantsInZone(GardenEntity.hardinessZone myZone)
        {
            GardenDAO gardenDAO = new GardenDAO();
            List<GardenEntity> gardenEntityList = new List<GardenEntity>();
            if (gardenDAO != null)
            {
                gardenEntityList = gardenDAO.ListPlantsInZone(myZone);
            }
            else
            {
                throw new Exception("GardenDAO is null. ListPlantsInZone");
            }
            return gardenEntityList;
        }

        public List<GardenEntity> ListPlantsRequireThisSunExposure(GardenEntity.sunExposure mySun)
        {
            GardenDAO gardenDAO = new GardenDAO();
            List<GardenEntity> gardenEntityList = new List<GardenEntity>();
            if (gardenDAO != null)
            {
                gardenEntityList = gardenDAO.ListPlantsRequireThisSunExposure(mySun);
            }
            else
            {
                throw new Exception("GardenDAO is null. ListPlantsRequireThisSunExposure");
            }
            return gardenEntityList;
        }

        public List<GardenEntity> PlantsToPlantInThisMonth(GardenEntity.Month thisMonth)
        {
            GardenDAO gardenDAO = new GardenDAO();
            List<GardenEntity> gardenEntityList = new List<GardenEntity>();
            if (gardenDAO != null)
            {
                gardenEntityList = gardenDAO.PlantsToPlantInThisMonth(thisMonth);
            }
            else
            {
                throw new Exception("GardenDAO is null. PlantsToPlantInThisMonth");
            }
            return gardenEntityList;
        }
    }
}
