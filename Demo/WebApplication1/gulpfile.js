/// <vs AfterBuild='default' SolutionOpened='watch' />
var gulp = require('gulp');
var gutil = require('gulp-util');
var bower = require('bower');
var concat = require('gulp-concat');
var minifyCss = require('gulp-minify-css');
var rename = require('gulp-rename');
var sh = require('shelljs');
var clean = require('gulp-clean');

var paths = {
	css: ['./Content/*.css', '!./Content/*.min.css'],
	cssmin: ['./Content/*.min.css']
};

gulp.task('default', ['cssmin']);

gulp.task('cssmin', function(done) {
  gulp.src(paths.css)
    .pipe(minifyCss({
	 keepSpecialComments: 0
    }))
    .pipe(rename({ extname: '.min.css' }))
    .pipe(gulp.dest('./Content/'))
    .on('end', done);
});

gulp.task('watch', function() {
  gulp.watch(paths.css, ['cssmin']);
});

gulp.task('clean', function () {
	return gulp.src(paths.cssmin)
	.pipe(clean());
});
