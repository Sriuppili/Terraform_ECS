#terraform {
#  backend "s3" {
#    bucket       = "ecs-terraform-state" 
#    key          = "ecs/terraform"
#    region       = var.region_name
#    use_lockfile = true

#  }
#}