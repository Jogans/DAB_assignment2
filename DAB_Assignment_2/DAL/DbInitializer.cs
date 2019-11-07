using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAB_Assignment_2.Models;
using DAB_Assignment_2.RelationshipClasses;
namespace DAB_Assignment_2.DAL
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            //Tilføj ting her

            context.SaveChanges();

            var restaurants = new Restaurant[]
            {
                new Restaurant{Name = "Bob's Place", Address = "Mordor Lane 35", AverageRating = 2, Type = "Dessert"},
                new Restaurant{Name = "The Golden Seagull", Address = "Fast Food Road 88", AverageRating = 4, Type = "Dinner"},
                new Restaurant{Name = "Jelle's Icecream Bar", Address = "Candy Way 15", AverageRating = 0.1, Type = "Dessert"},
                new Restaurant{Name = "Nicolo's Pizza", Address = "Growl Hill 32", AverageRating = 3, Type = "Lunch"},
                new Restaurant{Name = "Jogan's Fine Dining", Address = "Fancy Boulevard 1", AverageRating = 1, Type = "Dinner"},
                new Restaurant{Name = "Frederico's Breakfast", Address = "Early Bird 75", AverageRating = 3.5, Type = "Breakfast"},
                new Restaurant{Name = "Pregante's Sanwitch", Address = "Strange Green 2", AverageRating = 1, Type = "Lunch"},
                new Restaurant{Name = "Only Coffee", Address = "Sleepy Road 14", AverageRating = 5, Type = "Breakfast"},


            };
            foreach (Restaurant c in restaurants)
            {
                context.Restaurants.Add(c);
            }
            context.SaveChanges();

            var dishes = new Dish[]
            {
                new Dish{DishName = "Cheese Burger", Price = 14, Type = "Main Course"},
                new Dish{DishName = "Bananasplit", Price = 20, Type = "Dessert"},
                new Dish{DishName = "Breadsticks", Price = 10, Type = "Appetizer"},
                new Dish{DishName = "T-Bone", Price = 120, Type = "Main Course"},
                new Dish{DishName = "Sirloin Steak", Price = 110, Type = "Main Course"},
                new Dish{DishName = "Muffin", Price = 15, Type = "Dessert"},
                new Dish{DishName = "King Crabs", Price = 40, Type = "Appetizer"},
                new Dish{DishName = "Hamburger", Price = 12, Type = "Main Course"},
                new Dish{DishName = "Bacon Orionrings", Price = 33, Type = "Appetizer"},
                new Dish{DishName = "Hashbrowns", Price = 20, Type = "Appetizer"},
                new Dish{DishName = "Milkshake", Price = 30, Type = "Dessert"},
                new Dish{DishName = "Pizza Slice", Price = 20, Type = "Main Course"},
                new Dish{DishName = "Dates with Bacon", Price = 30, Type = "Appetizer"},
                new Dish{DishName = "Chilli Chesse Tops", Price = 8, Type = "Appetizer"},
                new Dish{DishName = "Pain au Chocolat", Price = 8, Type = "Appetizer"},
                new Dish{DishName = "Ice Cream", Price = 12, Type = "Dessert"},
                new Dish{DishName = "Coffee", Price = 15, Type = "Dessert"},

            };
            foreach (Dish d in dishes)
            {
                context.Dishes.Add(d);
            }
            context.SaveChanges();

            var restaurantDishes = new RestaurantDish[]
            {
                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Pain au Chocolat").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Muffin").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Bacon Orionrings").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Chilli Chesse Tops").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Hamburger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Bananasplit").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Ice Cream").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Muffin").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Pizza Slice").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Hamburger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Dates with Bacon").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "King Crabs").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "T-Bone").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Sirloin Steak").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Pain au Chocolat").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Hashbrowns").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Milkshake").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Cheese Burger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Hamburger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId
                },

                new RestaurantDish
                {
                    DishId = dishes.Single(d => d.DishName == "Coffee").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId
                },

            };
            foreach (RestaurantDish rd in restaurantDishes)
            {
                context.RestaurantDishes.Add(rd);
            }
            context.SaveChanges();

            var tabels = new Table[]
            {
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    TableId = 1,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    TableId = 2,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    TableId = 3,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    TableId = 4,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    TableId = 5,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    TableId = 6,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    TableId = 7,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    TableId = 8,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    TableId = 9,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    TableId = 10,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = 11,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = 12,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = 13,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = 14,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = 15,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    TableId = 16,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    TableId = 17,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    TableId = 18,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    TableId = 19,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    TableId = 20,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = 21,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = 22,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = 23,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = 24,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = 25,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    TableId = 26,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    TableId = 27,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    TableId = 28,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    TableId = 29,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    TableId = 30,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId,
                    TableId = 31,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId,
                    TableId = 32,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId,
                    TableId = 33,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId,
                    TableId = 34,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId,
                    TableId = 35,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId,
                    TableId = 36,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId,
                    TableId = 37,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId,
                    TableId = 38,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId,
                    TableId = 39,
                },
                new Table
                {
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId,
                    TableId = 40,
                },
            };
            foreach (Table t in tabels)
            {
                context.Tables.Add(t);
            }
            context.SaveChanges();

            var reviews = new Review[]
            {
                new Review{
                    Text = "Genial Mad oplevelse", 
                    Stars = 5 , DishId = dishes.Single(d => d.DishName == "Cheese Burger").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 6).TableId,
                }, 
                new Review
                {
                    Text = "Jeg fortrød lidt at jeg gik herhen", 
                    Stars = 2, DishId = dishes.Single(d => d.DishName == "Bananasplit").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 11).TableId,
                }, 
                new Review
                {
                    Text = "AD!!!!", 
                    Stars = 1, DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 26).TableId,
                }, 
                new Review
                {
                    Text = "God betjening og en behagelig oplevelse", 
                    Stars = 4, DishId = dishes.Single(d => d.DishName == "T-Bone").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 21).TableId,
                }, 
                new Review
                {
                    Text = "Okay til pengene",
                    Stars = 3, DishId = dishes.Single(d => d.DishName == "Sirloin Steak").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 21).TableId,
                }, 
                new Review
                {
                    Text = "Uhmmm det kan godt anbefales. Lækkert mad",
                    Stars = 4, DishId = dishes.Single(d => d.DishName == "Muffin").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 12).TableId,
                }, 
                new Review
                {
                    Text = "Hundeæde!!!",
                    Stars = 1, DishId = dishes.Single(d => d.DishName == "King Crabs").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 22).TableId,
                }, 
                new Review
                {
                    Text = "The sprinkling of gold flakes lent a top note of bullshit. And that was the good part. The skin had an off-putting tang and a rancid flavor, which seeped into the dried-out meat and left a greasy feeling on the roof of my mouth that, like the demonic clown from It, could not be destroyed",
                    Stars = 2, DishId = dishes.Single(d => d.DishName == "Hamburger").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Pregante's Sanwitch").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 31).TableId,
                }, 
                new Review
                {
                    Text = "Slowly, gradually, with great mental resistance but still inexorably, it dawned on me that I had paid $98 for a duck with almost no flavor. It was dry, too", 
                    Stars = 1, DishId = dishes.Single(d => d.DishName == "Bacon Orionrings").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 7).TableId,
                }, 
                new Review
                {
                    Text = "When executed poorly (a gummy mass of vermicelli and shellfish that is presumably a riff on the Korean noodle dish japchae), his dishes just sing out of key",
                    Stars = 2, DishId = dishes.Single(d => d.DishName == "Hashbrowns").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="Frederico's Breakfast").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 27).TableId,
                }, 
                new Review
                {
                    Text = "You’d better have something in the fridge at home, because the likelihood of your joining the Clean Plate Club here is as good as Omarosa Manigault Newman getting invited to a Christmas party at the White House",
                    Stars = 5, DishId = dishes.Single(d => d.DishName == "Milkshake").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 18).TableId,
                }, 
                new Review
                {
                    Text = "While there are many words I could use to describe Nicolo's Pizza, I’m going to say only this: Nicolo's Pizza is a bad restaurant", 
                    Stars = 1, DishId = dishes.Single(d => d.DishName == "Pizza Slice").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 19).TableId,
                }, 
                new Review
                {
                    Text = "The initial flavor was bland, quickly followed by a fetid, ammonia-like tang. It was an aroma that recalled room-temperature hamburger meat from a grocer that lost power. I felt my eyes water up as I chewed. I tried to swallow. I felt my entire GI tract prepare to purge", 
                    Stars = 2, DishId = dishes.Single(d => d.DishName == "Dates with Bacon").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 23).TableId,
                }, 
                new Review
                {
                    Text = "Did it have ‘a simple flavor with a touch of sweetness’? It was hard to say after half of it had been simmered in soy sauce to a bony mush, the other half grilled in salt until chewy and served with its head still on, propped up with a wooden stake like a Big Mouth Billy Bass about to sing",
                    Stars = 5, DishId = dishes.Single(d => d.DishName == "Chilli Chesse Tops").DishId,
                    RestaurantId = restaurants.Single(r => r.Name=="The Golden Seagull").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 8).TableId,
                }, 
                new Review
                {
                    Text = "When compared to similar restaurants, “Empire is their hollow echo, parroting back a faded, carbon-copied version that takes no risks and contributes little to Detroit’s dining scene dialogue", 
                    Stars = 3, DishId = dishes.Single(d => d.DishName == "Pain au Chocolat").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 5).TableId,
                }, 
                new Review
                {
                    Text = "There’s V for Vegan. There’s GF for Gluten Free. There’s DF for Dairy Free. I think they’re missing a few. There should be TF for Taste Free and JF for Joy Free and AAHYWEH for Abandon All Hope, Ye Who Enter Here", 
                    Stars = 1, DishId = dishes.Single(d => d.DishName == "Ice Cream").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 13).TableId,
                },
                new Review
                {
                    Text = "Nobody told the recipe developer that Americans don’t much like small, stale peas in their pasta", 
                    Stars = 1, DishId = dishes.Single(d => d.DishName == "Coffee").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="Only Coffee").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 38).TableId,
                },
                new Review
                {
                    Text = "Nobody should pay this much money to be sad", 
                    Stars = 2, DishId = dishes.Single(d => d.DishName == "Sirloin Steak").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="Jogan's Fine Dining").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 24).TableId,
                },
                new Review
                {
                    Text = "McDonald’s does a better job for one-third of the price", 
                    Stars = 1, DishId = dishes.Single(d => d.DishName == "Bananasplit").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="Jelle's Icecream Bar").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 14).TableId,
                },
                new Review
                {
                    Text = "I’m not so batty from Trump Derangement Syndrome that I can’t objectively identify what a poor value the food is at Nicolo's Pizza. The only thing Chicagoans on the ground are missing is the spectacular view from occupied territory", 
                    Stars = 3, DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="Nicolo's Pizza").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 18).TableId,
                },
                new Review
                {
                    Text = "To put it mildly, licking Plexiglas is more rewarding than some of the duds on the set menu", 
                    Stars = 2, DishId = dishes.Single(d => d.DishName == "Breadsticks").DishId, 
                    RestaurantId = restaurants.Single(r => r.Name=="Bob's Place").RestaurantId,
                    TableId = tabels.Single(t => t.TableId == 4).TableId,
                },
            };
            foreach (Review rw in reviews)
            {
                context.Reviews.Add(rw);
            }
            context.SaveChanges();


            var guests = new Guest[]
            {
                new Guest
                {
                    Name = "Anders Andersen",
                },
                new Guest
                {
                    Name = "Hanne Hansen",
                },
                new Guest
                {
                    Name = "Christiane Christiansen",
                },
                new Guest
                {
                    Name = "Charlotte Charlottenborg",
                },
                new Guest
                {
                    Name = "Rasmus Rasmussen",
                },
                new Guest
                {
                    Name = "Nicolai Nicolajsen",
                },
                new Guest
                {
                    Name = "Jesper Jespersen",
                },
                new Guest
                {
                    Name = "Mette Metz",
                },
                new Guest
                {
                    Name = "Anna Antonsen",
                },
                new Guest
                {
                    Name = "A.S. Muncher",
                },
                new Guest
                {
                    Name = "Anita Dick",
                },
                new Guest
                {
                    Name = "Ben Derhover",
                },
                new Guest
                {
                    Name = "Dixon B. Tweenerlegs",
                },
                new Guest
                {
                    Name = "Dixon Butts",
                },
                new Guest
                {
                    Name = "Harry Nutt",
                },
                new Guest
                {
                    Name = "Ivana Fuccu",
                },
                new Guest
                {
                    Name = "Ivanna B. Spanked",
                },
                new Guest
                {
                    Name = "Mike Hunt",
                },
                new Guest
                {
                    Name = "Phil McAvity",
                },
                new Guest
                {
                    Name = "Wilma Dickfit",
                },

            };

            foreach (Guest w in guests)
            {
                context.Guests.Add(w);
            }
            context.SaveChanges();

            var waiters = new Waiter[]
            {
                new Waiter
                {
                    Name = "Jens Jensen",
                    Salary = 110,

                },
                new Waiter
                {
                    Name = "Trine Triger",
                    Salary = 110,


                },
                new Waiter
                {
                    Name = "Frederik Frederico",
                    Salary = 110,

                },
                new Waiter
                {
                    Name = "A. Nelprober",
                    Salary = 110,

                },
                new Waiter
                {
                    Name = "Dick Long",
                    Salary = 110,

                },
                new Waiter
                {
                    Name = "Hugh Janus",
                    Salary = 110,

                },
                new Waiter
                {
                    Name = "Moe Lester",
                    Salary = 110,

                },
                new Waiter
                {
                    Name = "Ho Lee Fuk",
                    Salary = 110,

                },
            };
            foreach (Waiter w in waiters)
            {
                context.Waiters.Add(w);
            }
            context.SaveChanges();


            //Tilføj ting her




            //Tilføj ting her

            context.SaveChanges();
        }
    }
}
