// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryModelClass.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.InventoryDetails
{
    using System;

    /// <summary>
    /// Creating one class for inventory Model
    /// </summary>
    public class InventoryModelClass
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The weight
        /// </summary>
        private double weight;

        /// <summary>
        /// The priceperkg
        /// </summary>
        private double priceperkg;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        /// <summary>
        /// Gets or sets the per kilogram..
        /// </summary>
        /// <value>
        /// The price per kilogram.
        /// </value>
        public double Priceperkg
        {
            get
            {
                return this.priceperkg;
            }
            set
            {
                this.priceperkg = value;
            }
        }
    }
}
