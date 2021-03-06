﻿using Ecommerce.Core.DomainObjects;
using System.Collections.Generic;

namespace Ecommerce.Catalog.Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; private set; }
        public int Code { get; private set; }

        // EF Relation
        public ICollection<Product> Products { get; private set; }

        protected Category() { }

        public Category(string name, int code)
        {
            Name = name;
            Code = code;
            Validate();
        }

        public override string ToString()
        {
            return $"{Name} - {Code}";
        }

        public void Validate()
        {
            AssertionConcern.ValidateIfEmpty(Name, "Category Name field cannot be empty");
            AssertionConcern.ValidateIfLessThanMin(Code, 0, "Code field cannot be 0");
        }
    }
}
