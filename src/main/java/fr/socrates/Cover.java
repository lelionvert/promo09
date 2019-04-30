package fr.socrates;

class Cover {
    private String type;

    Cover(String type) {
        this.type = type;
    }

    boolean isVegetarian() {
        return type.equals("vegetarian");
    }
}
