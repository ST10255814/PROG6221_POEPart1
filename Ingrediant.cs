using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ingrediant
{

	public string ingrediantName;
	public string unitOfMeasure;
	public int amount;

	public string getIngrediantName()
	{
		return ingrediantName;
	}
	public void setIngrediantName(string value)
	{
		ingrediantName = value;
	}
	public int getAmount()
	{
		return amount;
	}
	public void setAmount(int value)
	{
		amount = value;
	}
	public string getUnitOfMeasure()
	{
		return unitOfMeasure;
	}
	public void setUnitOfMeasure(string value) 
	{
		unitOfMeasure = value;
	}
}
