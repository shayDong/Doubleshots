public class ingredient {
	String name;
	int index;

	public ingredient (String name, int index){
		this.name = name;
		this.index = index;
	}

	public String getName(){
		return name;
	}

	public int getIndex(){
		return index;
	}
}

public class drink {
	String name;
	int[] recipe;

	public drink(String name, int[] recipe){
		this.name = name;
		this.recipe = recipe;
	}

	public String getName(){
		return name;
	}

	public int[] getRecipe(){
		return recipe;
	}
}

//Will be placed in a start function
//Initializes ingredient array
public ingredient[] initIngredients(){
	ingredient[] selection = new ingredient[4]

	ingredient[0] = ingredient("empty", 0);
	ingredient[1] = ingredient("red"  , 1);
	ingredient[2] = ingredient("blue" , 2);
	ingredient[3] = ingredient("green", 3);

	return selection;
}


public drink[] initDrinks(){
	drink[] menu = new drink[4];

	//Ingredient indeces sorted from least to greatest
	drink[0] = drink("strange", [-1, -1, -1]);
	drink[1] = drink("red"    , [0 , 0 , 1 ]);
	drink[2] = drink("blue"   , [0 , 0 , 2 ]);
	drink[3] = drink("green"  , [0 , 0 , 3 ]);
	drink[4] = drink("purple" , [0 , 1 , 2 ]);

	return menu;
}

//Assumes menu array is accessible and called menu[]
public drink mixDrink(ingredient one, ingredient two, ingredient three){
	int temp;
	int[] ingredients = [one.getIndex(), two.getIndex(), three.getIndex()];

	//Sorts ingredient indeces from least to greatest
	for(int c = 0; c<3; c++){
		for(int d = c; d<3; d++){
			if (ingredients[c] > ingredients[d]){
				temp = ingredients[c];
				ingredients[c] = ingredients[d];
				ingredients[d] = temp;
			}
		}
	}

	//Searches drink list for list that gives the same ingredients array
	for(int c = 1; c<menu.length; c++){
		if(ingredients.Equals(menu[c].getRecipe() == ingredients)){
			return menu[c];
		}
	}

	//Returns always wrong drink if no matching drink
	return menu[0];
}
