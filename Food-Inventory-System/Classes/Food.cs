using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Inventory_System.Classes
{
    public class Food
    {
        private string foodID;
        private string foodName;
        private int quantity;
        private Category category;
        private DateTime expiryDate;
        private StorageLocation storageLocation;
        private Status status;

        public Food(string foodID, string foodName, int quantity, Category category, DateTime expiryDate, StorageLocation storageLocation, Status status)
        {
            this.foodID = foodID;
            this.foodName = foodName;
            this.quantity = quantity;
            this.category = category;
            this.expiryDate = expiryDate;
            this.storageLocation = storageLocation;
            this.status = status;
        }   

        public int Quantity {  get { return quantity; } set { quantity = value; } }
        public string FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }

        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }

      

        public Category Category
        {
            get{ return category; }
            set { category = value; }
        }

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        public StorageLocation StorageLocation
        {
            get { return storageLocation; }
            set { storageLocation = value; }
        }

        public Status Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
