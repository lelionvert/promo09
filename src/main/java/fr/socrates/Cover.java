package fr.socrates;

class Cover {
    private DietType dietType;

    Cover(DietType dietType) {
        this.dietType = dietType;
    }

    boolean isVegetarian() {
        return this.dietType.equals(DietType.VEGETARIAN);
    }

    boolean isPescatarian() {
        return this.dietType.equals(DietType.PESCATARIAN);
    }
}
