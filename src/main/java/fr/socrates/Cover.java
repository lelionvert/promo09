package fr.socrates;

class Cover {
    private DietType dietType;

    Cover(DietType dietType) {
        this.dietType = dietType;
    }

    boolean hasDietType(DietType dietType) {
        return this.dietType.equals(dietType);
    }
}
