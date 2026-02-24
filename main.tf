module "vpc" {
  source = "./modules/vpc"
  region_name = var.region_name
  vpc_cidr = var.vpc_cidr
  public_subnet_cidr = var.public_subnet_cidr
  private_subnet_cidr = var.private_subnet_cidr
}

module "ecs" {
    source = "./modules/ecs"
    vpc_id = module.vpc.vpc_id
    public_subnet_id = var.public_subnet_cidr
    private_subnet_id = var.private_subnet_cidr
}
